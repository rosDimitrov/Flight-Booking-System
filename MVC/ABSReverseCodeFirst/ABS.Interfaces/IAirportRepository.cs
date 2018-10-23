using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface IAirportRepository
    {
        void AddAirport(string airportName);
        bool AirportExists(string airportName);
    }
}
