using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

using MyLib.FlightCalculation;

namespace FlightTracker
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WebClient webClient = new WebClient();
        DataLoader datas = new DataLoader();
        Airports airports = new Airports();

        /// <summary>
        /// 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            InitTimer();
            flightList.SelectionChanged += (a, b) => OnFlightSelected(flightList.SelectedIndex);
            refreshButton.Click += (_sender, _routedEventArgs) => OnRefreshed(_sender, _routedEventArgs);
            string _jsonPilots = webClient.DownloadString("https://data.vatsim.net/v3/vatsim-data.json");
            flightList.ItemsSource = datas.LoadFlights(_jsonPilots).Pilots;
            airports = datas.LoadAirports("airports.json");
        }

        void InitTimer()
        {
            DispatcherTimer _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += (a, b) => UpdateTime();
            _timer.Start();
        }
        void UpdateTime()
        {
            DateTime _dateTime = DateTime.Now;
            dateAndTimeLabel.Content = $"{_dateTime.ToString()}";
        }

        float GetLatInFloat(string _value)
        {
            return float.Parse(_value.Replace('.', ','));
        }
        void OnFlightSelected(int _index)
        {
            if (_index < 0 || _index > flightList.Items.Count) return;
            Pilot _currentPilot = (Pilot)flightList.Items[_index];
            if (_currentPilot.Flight_Plan == null) return;

            Airport _aiportDeparture = airports.FindAirport(_currentPilot.Flight_Plan.Departure);
            if (_aiportDeparture == null) { _aiportDeparture = new Airport() { Name = "Missing Informations" }; return; }
            Airport _aiportArrival = airports.FindAirport(_currentPilot.Flight_Plan.Arrival);
            if (_aiportArrival == null) { _aiportArrival = new Airport() { Name = "Missing Informations" }; return; }

            float _distanceTravelled = FlightCalculation.DistanceCalculation(GetLatInFloat(_aiportDeparture.Lat), GetLatInFloat(_aiportDeparture.Lon), _currentPilot.Latitude, _currentPilot.Longitude);
            float _disctanceToTravel = FlightCalculation.DistanceCalculation(GetLatInFloat(_aiportDeparture.Lat), GetLatInFloat(_aiportDeparture.Lon), GetLatInFloat(_aiportArrival.Lat), GetLatInFloat(_aiportArrival.Lon));
            int _percentage = FlightCalculation.GetDistanceRemainingInPercentage(_distanceTravelled, _disctanceToTravel);

            journeyLabel.Content = $"{_currentPilot.Flight_Plan.Departure} ({_aiportDeparture.Name}) to {_currentPilot.Flight_Plan.Arrival} ({_aiportArrival.Name})";
            flyingProgressLabel.Content = $"{_distanceTravelled} / {_disctanceToTravel} nm - {_percentage}%";
            flyingProgressBar.Value = _percentage;
            Process.Start($"https://www.google.fr/maps/place/{_currentPilot.Latitude.ToString().Replace(',', '.')}+{_currentPilot.Longitude.ToString().Replace(',', '.')}/");
        }
        void OnRefreshed(object _sender, RoutedEventArgs _routedEventArgs)
        {
            refreshButton.Background = Brushes.Red;
            string _jsonPilots = webClient.DownloadString("https://data.vatsim.net/v3/vatsim-data.json");
            flightList.ItemsSource = datas.LoadFlights(_jsonPilots).Pilots;
            refreshButton.Background = Brushes.White;
        }
    }
}