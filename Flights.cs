using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTracker
{
    /// <summary>
    /// 
    /// </summary>
    public class Flights
    {
        /// <summary>
        /// 
        /// </summary>
        public GeneralData General { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Pilot this[int _index] => Pilots[_index];
        /// <summary>
        /// 
        /// </summary>
        public Pilot[] Pilots { get; set; }
    }
}
