using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface IAirportManager
    {
        string Message { get; }

        void AddAirport(string airportName);
    }
}
