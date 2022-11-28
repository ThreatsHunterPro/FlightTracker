using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerCorr.Source
{
    public interface IDatabase<T>
    {
        int Total { get; }
        T this[int _i] { get; }
    }
}
