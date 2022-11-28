using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public class Pilot
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public FlightPlan Flight_Plan { get; set; }
        public bool IsFlightPlanValid => Flight_Plan != null;
        public string LatitudeString => Latitude.ToString().Replace(',', '.');
        public string LongitudeString => Longitude.ToString().Replace(',', '.');
    }
    public class FlightPlan
    {
        public string Departure { get; set; }
        public string Arrival { get; set; }
    }
}
