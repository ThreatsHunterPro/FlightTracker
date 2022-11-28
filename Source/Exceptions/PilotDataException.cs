using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public class PilotDataException : Exception
    {
        public override string Message => "Error : Could not retrieve Pilots Data";
    }
}
