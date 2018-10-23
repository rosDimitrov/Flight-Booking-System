using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface IAirlineRepository
    {
        void AddAirline(string airlineName);
        bool AirlineExists(string airlineName);
    }
}
