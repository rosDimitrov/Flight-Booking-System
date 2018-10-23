using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface ISectionManager
    {
        string Message { get; }
        void AddSection(string airlineName, string flightId, int rows, int cols, string sectionType);
    }
}
