using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public class PilotsDB : IDatabase<Pilot>
    {
        public Pilot[] Pilots { get; set; }
        public Pilot this[int _index] => Pilots[_index];
        public int Total => Pilots.Length;
    }
}
