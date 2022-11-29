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
    public class Flight
    {
        /// <summary>
        /// 
        /// </summary>
        public string FlightRules { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AirCraft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AirCraftFaa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AirCraftShort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Departure { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Arrival { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Alternate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CruiseTas { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Altitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DepTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EnRouteTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FuelTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Route { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int RevisionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AssignedTransponder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LogonTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_flightRules"></param>
        /// <param name="_airCraft"></param>
        /// <param name="_airCraftFaa"></param>
        /// <param name="_airCraftShort"></param>
        /// <param name="_departure"></param>
        /// <param name="_arrival"></param>
        /// <param name="_alternate"></param>
        /// <param name="_cruiseTas"></param>
        /// <param name="_altitude"></param>
        /// <param name="_depTime"></param>
        /// <param name="_enRouteTime"></param>
        /// <param name="_fuelTime"></param>
        /// <param name="_remarks"></param>
        /// <param name="_route"></param>
        /// <param name="_revisionId"></param>
        /// <param name="_assignedTransponder"></param>
        /// <param name="_logonTime"></param>
        /// <param name="_lastUpdated"></param>
        public Flight(string _flightRules, string _airCraft, string _airCraftFaa, string _airCraftShort,
                      string _departure, string _arrival, string _alternate, string _cruiseTas, string _altitude,
                      string _depTime, string _enRouteTime, string _fuelTime, string _remarks, string _route,
                      int _revisionId, string _assignedTransponder, string _logonTime, string _lastUpdated)
        {
            FlightRules = _flightRules;
            AirCraft = _airCraft;
            AirCraftFaa = _airCraftFaa;
            AirCraftShort = _airCraftShort;
            Departure = _departure;
            Arrival = _arrival;
            Alternate = _alternate;
            CruiseTas = _cruiseTas;
            Altitude = _altitude;
            DepTime = _depTime;
            EnRouteTime = _enRouteTime;
            FuelTime = _fuelTime;
            Remarks = _remarks;
            Route = _route;
            RevisionId = _revisionId;
            AssignedTransponder = _assignedTransponder;
            LogonTime = _logonTime;
            LastUpdated = _lastUpdated;
        }
    }
}
