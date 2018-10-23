using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface IAirlineManager
    {
        string Message { get; }

        void AddAirline(string airlineName);
    }
}
