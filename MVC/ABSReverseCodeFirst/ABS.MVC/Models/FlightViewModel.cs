using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ABS.MVC.Models
{

    public class FlightViewModel
    {
        [DisplayName("Airline Name")]
        public string AirlineName { get; set; }

        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        [DisplayName("Flight Id")]
        public string FlightId { get; set; }
    }
}