using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface ISeatManager
    {
        string Message { get; }

        void BookSeat(string airline, string flightId, string seatType, int row, int col);
    }
}
