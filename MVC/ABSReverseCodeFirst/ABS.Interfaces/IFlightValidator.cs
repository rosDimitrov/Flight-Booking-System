using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface IFlightValidator
    {
        string Message { get; }
        bool ValidateFlightRoute(string origin, string destination);

        bool ValidateFlightSectionRowsCols(int rows, int cols);

        bool ValidateFlightDate(int year, int month, int day);

    }
}
