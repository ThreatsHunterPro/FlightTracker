using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public class AirportDataException : Exception
    {
        public override string Message => "Error : Could not retrieve Airports Data";
    }
}
