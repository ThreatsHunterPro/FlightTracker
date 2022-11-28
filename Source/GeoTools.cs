using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace FlightTrackerCorr.Source
{
    public class GeoTools
    {
        const double NM_CONVERT = 0.0005399568;
        public static int GetPercentProgressTo(double _current, double _max) => (int)((_current / _max) * 100);

        public static double GetDistanceTo(Pilot _pilot, Airport _to)
        {
            if (_to == null) return 0;
            GeoCoordinate _pilotCoord = new GeoCoordinate(_pilot.Latitude, _pilot.Longitude);
            GeoCoordinate _toCoord = new GeoCoordinate(_to.Lat, _to.Lon);
            return _pilotCoord.GetDistanceTo(_toCoord) * NM_CONVERT;
        }
        public static double GetDistanceTo(Airport _from, Airport _to)
        {
            if (_from == null || _to == null) return 0;
            GeoCoordinate _fromCoord = new GeoCoordinate(_from.Lat, _from.Lon);
            GeoCoordinate _toCoord = new GeoCoordinate(_to.Lat, _to.Lon);
            return _fromCoord.GetDistanceTo(_toCoord) * NM_CONVERT;
        }
    }
}
