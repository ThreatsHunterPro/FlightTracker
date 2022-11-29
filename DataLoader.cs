using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;

namespace FlightTracker
{
    /// <summary>
    /// 
    /// </summary>
    public class DataLoader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>
        public Airports LoadAirports(string _path)
        {
            if (string.IsNullOrEmpty(_path) || !File.Exists(_path)) return null;
            string _airportsText = File.ReadAllText(_path);
            return JsonConvert.DeserializeObject<Airports>(_airportsText);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>
        public Flights LoadFlights(string _path)
        {
            if (string.IsNullOrEmpty(_path)) return null;
            return JsonConvert.DeserializeObject<Flights>(_path);
        }
    }                   
}
