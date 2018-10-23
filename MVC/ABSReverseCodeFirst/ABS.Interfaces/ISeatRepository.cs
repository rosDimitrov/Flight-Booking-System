using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface ISeatRepository
    {
        void BookSeat(string airline, string flightId, string seatType, int row, int col);
        bool AirlineExists(string airline);
        bool FlightExists(string airline, string flightId);
        bool FlightSectionExists(string airline, string flightId, string seatType);
        bool SeatExistsAndNotTaken(string airline, string flightId, string seatType, int row, int col);
    }
}
