using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public class AirportDatabase
    {
        Dictionary<string, Airport> AllAirports = new Dictionary<string, Airport>();
        public void AddAirport(Airport _airport)
        {
            if (Exists(_airport.ICAO)) return;
            AllAirports.Add(_airport.ICAO, _airport);
        }
        public bool Exists(string _ICAO) => AllAirports.ContainsKey(_ICAO);
        public Airport GetAirport(string _ICAO)
        {
            if (!Exists(_ICAO)) return null;
            return AllAirports[_ICAO];
        }
    }
}
