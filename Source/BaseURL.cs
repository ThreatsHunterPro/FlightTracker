using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public class BaseURL
    {
        public const string GET_PILOTS_API = "https://data.vatsim.net/v3/vatsim-data.json";
        public const string GET_AIRPORTS_API = "https://gist.githubusercontent.com/tdreyno/4278655/raw/7b0762c09b519f40397e4c3e100b097d861f5588/airports.json";
        public const string GET_GOOGLE_LOC_API = "https://www.google.fr/maps/@{0},{1},{2}z";
    }
}
