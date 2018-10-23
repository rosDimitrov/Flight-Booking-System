using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ABS.MVC.Models
{
    public class BookSeatViewModel
    {
        public string Airline { get; set; }

        [DisplayName("Flight Id")]
        public string FlightId { get; set; }

        [DisplayName("Seat Type")]
        public string SeatType { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}