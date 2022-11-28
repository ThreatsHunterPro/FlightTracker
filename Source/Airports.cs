using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public class Airports : IDatabase<Airport>
    {
        public Airport[] AirportsDB { get; set; }
        public Airport this[int _i] => AirportsDB[_i];
        public int Total => AirportsDB.Length;
    }
}
