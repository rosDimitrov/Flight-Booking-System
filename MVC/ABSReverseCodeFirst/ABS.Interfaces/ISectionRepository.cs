using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface ISectionRepository
    {
        void AddSection(string airlineName, string flightId, int rows, int cols, string sectionType);
        bool AirlineExists(string airlineName);
        bool FlightExists(string airlineName, string flightId);
        bool FlightSectionTypeExists(string airlineName, string flightId, string sectionType);
    }
}
