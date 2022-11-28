using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;

namespace FlightTrackerCorr.Source
{
    public class DataAPI
    {
        public static void GetDataFromAPI(string _url, Action<DownloadStringCompletedEventArgs> _callback)
        {
            WebClient _request = new WebClient();
            if (string.IsNullOrEmpty(_url)) return;
            _request.DownloadStringCompleted += (_sender, _event) => _callback(_event);
            _request.DownloadStringAsync(new Uri(_url));
        }
        public static void GetData<T, TExc>(DownloadStringCompletedEventArgs _results, string _jsonFormat, Action<T> _callback) 
                                            where TExc:Exception, new()
        {
            if(_results.Error != null) throw new TExc();
            string _jsonData = _jsonFormat;
            T _data = JsonConvert.DeserializeObject<T>(_jsonData);
            _callback?.Invoke(_data);
        }
        public static void GetWorldLocation(Pilot _origin)
        {
            Process.Start(string.Format(BaseURL.GET_GOOGLE_LOC_API, _origin.LatitudeString, _origin.LongitudeString, 10));
        }
    }
}
