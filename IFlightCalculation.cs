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
    public interface IFlightCalculation
    {
        /// <summary>
        /// 
        /// </summary>
        double DistanceCalculation(double _latA, double _lonA, double _latB, double _lonB);
        /// <summary>
        /// 
        /// </summary>
        double ConvertDistanceInNauticalMiles(double _distance);
        /// <summary>
        /// 
        /// </summary>
        int GetDistanceRemainingInPercentage(double _progress, double _maxDistance);
    }
}