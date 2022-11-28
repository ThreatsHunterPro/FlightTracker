using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr
{
    public class LoadingSystem
    {
        public event Action<float> OnUpdateProgress = null;
        public event Action<float> OnUpdatePercentProgress = null;
        int progress = 0;

        public void UpdateProgress(int _max)
        {
            progress++;
            progress = progress > _max ? _max : progress;
            float _progress = (float)progress / _max;
            OnUpdateProgress?.Invoke(_progress);
            OnUpdatePercentProgress?.Invoke(_progress * 100);
        }
        public void Reset()
        {
            progress = 0;
        }
    }
}
