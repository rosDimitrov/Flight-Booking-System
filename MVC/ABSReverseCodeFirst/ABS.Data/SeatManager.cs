using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Util;
using ABS.Interfaces;

namespace ABS.Data
{
    public class SeatManager : ISeatManager
    {
        private ISeatRepository seatRepository;
        private IFlightValidator flightValidator;
        public string Message { get; set; }

        public SeatManager(ISeatRepository seatRepository,IFlightValidator flightValidator)
        {
            this.seatRepository = seatRepository;
            this.flightValidator = flightValidator;
        }

        public void BookSeat(string airline, string flightId, string seatType, int row, int col)
        {
            if (seatRepository.SeatExistsAndNotTaken(airline, flightId, seatType, row, col))
            {
                seatRepository.BookSeat(airline, flightId, seatType, row, col);
            }
            else
            {
                //Трябва да се опише подробна грешката
                this.Message = "you have entered wrong data or the seat is taken";
            }
        }


    }
}
