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
    public class Airports
    {
        /// <summary>
        /// 
        /// </summary>
        public Airport this[int _index] => FlyingList[_index];
        /// <summary>
        /// 
        /// </summary>
        public Airport[] FlyingList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_code"></param>
        /// <returns></returns>
        public Airport FindAirport(string _code)
        {
            return FlyingList?.FirstOrDefault(_airport => _airport.Icao.Equals(_code));
        }
    }
}