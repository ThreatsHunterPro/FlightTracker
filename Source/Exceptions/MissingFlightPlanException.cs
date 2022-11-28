using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public class MissingFlightPlanException : Exception
    {
        public override string Message => "Missing Flight Plan : No Departure or Arrival available";
    }
}
