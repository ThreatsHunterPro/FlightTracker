using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FlightTrackerCorr.Source;
using System.Windows.Threading;

namespace FlightTrackerCorr
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event Action<Pilot, Airport, Airport> OnFlightSelected = null;

        Pilot[] pilots = new Pilot[0];
        AirportDatabase AirportDB = new AirportDatabase();
        LoadingSystem loading = new LoadingSystem();

        public MainWindow()
        {
            InitializeComponent();
            loading.OnUpdatePercentProgress += LoadingScreenProgress;
            reloadButton.Click += (_sender, _event) => OnReloadClicked(_sender, _event);
            InitFlightTracker();
        }
        void InitFlightTracker()
        {
            loading.Reset();
            LoadingScreenVisibility(Visibility.Visible);
            pilotList.SelectionChanged += (_sender, _eventArgs) => LoadFlightDatas();
            DataAPI.GetDataFromAPI(BaseURL.GET_AIRPORTS_API, (_aiports) =>
            DataAPI.GetData<Airports, AirportDataException>(_aiports, "{ \"AirportsDB\":" + _aiports.Result + "}", (_airport) =>
            {
                SetAirportDictionary(_airport);
                loading.UpdateProgress(2);
                DataAPI.GetDataFromAPI(BaseURL.GET_PILOTS_API, (_pilots) =>
                DataAPI.GetData<PilotsDB, PilotDataException>(_pilots, _pilots.Result, (_pilot) =>
                {
                    LoadPilotsData(_pilot);
                    loading.UpdateProgress(2);
                    LoadingScreenVisibility(Visibility.Hidden);
                }));
                
            }));
            OnFlightSelected += (_pilot, _from, _to) =>
            {
                SetFlightInfoValues(_pilot, _from, _to);
                DataAPI.GetWorldLocation(_pilot);
            };
        }
        void LoadingScreenProgress(float _percent)
        {
            loadingLabel.Content = $"Downloading flights : {_percent}%";
            loadingProgressBar.Value = _percent;
        }
        void LoadingScreenVisibility(Visibility _visibility)
        {
            loadingPage.Visibility = _visibility;
        }
        void SetAirportDictionary(Airports _allAirports)
        {
            for (int i = 0; i < _allAirports.Total; i++)
            {
                Airport _airport = _allAirports[i];
                AirportDB.AddAirport(_airport);
            }
        }
        void LoadPilotsData(PilotsDB _database)
        {
            pilots = _database.Pilots;
            pilotList.ItemsSource = _database.Pilots;
            totalFlightLabel.Content = $"Currently Tracking {_database.Total} flights";
        }
        void LoadFlightDatas()
        {
            if (pilotList.SelectedIndex < 0) return;
            Pilot _pilot = (Pilot)pilotList.Items[pilotList.SelectedIndex];
            if (!_pilot.IsFlightPlanValid)
            {
                MessageBox.Show(new MissingFlightPlanException().Message);
                return;
            }
            Airport _from = AirportDB.GetAirport(_pilot?.Flight_Plan.Departure);
            Airport _to = AirportDB.GetAirport(_pilot?.Flight_Plan.Arrival);
            OnFlightSelected?.Invoke(_pilot, _from, _to); 
        }
        void SetFlightInfoValues(Pilot _pilot, Airport _from, Airport _to)
        {
            if (_from == null || _to == null) return;
            double _fromDistance = GeoTools.GetDistanceTo(_pilot, _from);
            double _totalDistance = GeoTools.GetDistanceTo(_from, _to);
            int _progress = GeoTools.GetPercentProgressTo(_fromDistance, _totalDistance);
            flightInfo.Content = $"Current flight : {_from.Name} - {_to.Name}\n" +
                                 $"{(int)_fromDistance} nm / {(int)_totalDistance} nm - {_progress}%";
            flightProgressBar.Value = _progress;
        }
        void ResetFlightInfo()
        {
            flightInfo.Content = "Current flight :";
            flightProgressBar.Value = 0;
        }
        private void OnReloadClicked(object sender, RoutedEventArgs e)
        {
            DataAPI.GetDataFromAPI(BaseURL.GET_PILOTS_API, (_result) =>
                                   DataAPI.GetData<PilotsDB, PilotDataException>(_result, _result.Result, LoadPilotsData));
            ResetFlightInfo();
        }
    }
}
