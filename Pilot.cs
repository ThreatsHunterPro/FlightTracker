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
    public class Pilot
    {
        /// <summary>
        /// 
        /// </summary>
        public int Cid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CallSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PilotRating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float Latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float Longitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Altitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int GroundSpeed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Transponder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Heading { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double QnhIHg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int QnhMb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Flight Flight_Plan { get; set; }
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
        /// <param name="_cid"></param>
        /// <param name="_name"></param>
        /// <param name="_callSign"></param>
        /// <param name="_server"></param>
        /// <param name="_pilotRating"></param>
        /// <param name="_latitude"></param>
        /// <param name="_longitude"></param>
        /// <param name="_altitude"></param>
        /// <param name="_groundSpeed"></param>
        /// <param name="_transponder"></param>
        /// <param name="_heading"></param>
        /// <param name="_qnhIhg"></param>
        /// <param name="_qnhMb"></param>
        /// <param name="_flightPlan"></param>
        /// <param name="_logonTime"></param>
        /// <param name="_lastUpdated"></param>
        //public Pilot(int _cid, string _name, string _callSign, string _server, int _pilotRating,
        //             float _latitude, float _longitude, int _altitude, int _groundSpeed,
        //             string _transponder, int _heading, double _qnhIhg, int _qnhMb,
        //             Flight _flightPlan, string _logonTime, string _lastUpdated)
        //{
        //    Cid = _cid;
        //    Name = _name;
        //    CallSign = _callSign;
        //    Server = _server;
        //    PilotRating = _pilotRating;
        //    Latitude = _latitude;
        //    Longitude = _longitude;
        //    Altitude = _altitude;
        //    GroundSpeed = _groundSpeed;
        //    Transponder = _transponder;
        //    Heading = _heading;
        //    QnhIHg = _qnhIhg;
        //    QnhMb = _qnhMb;
        //    Flight_Plan = _flightPlan;
        //    LogonTime = _logonTime;
        //    LastUpdated = _lastUpdated;
        //}
    }
}
