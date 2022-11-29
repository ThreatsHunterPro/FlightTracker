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
    public class GeneralData
    {
        /// <summary>
        /// 
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Reload { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Update { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateTimesTamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Connected_Clients { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Unique_Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_version"></param>
        /// <param name="_reload"></param>
        /// <param name="_update"></param>
        /// <param name="_updateTimesTamp"></param>
        /// <param name="_connectedClients"></param>
        /// <param name="_uniqueUsers"></param>
        public GeneralData(int _version, int _reload, string _update, string _updateTimesTamp, int _connectedClients, int _uniqueUsers)
        {
            Version = _version;
            Reload = _reload;
            Update = _update;
            UpdateTimesTamp = _updateTimesTamp;
            Connected_Clients = _connectedClients;
            Unique_Users = _uniqueUsers;
        }
    }
}
