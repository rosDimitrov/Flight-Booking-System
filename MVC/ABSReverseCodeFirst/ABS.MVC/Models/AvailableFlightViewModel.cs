using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ABS.MVC.Models
{
    public class AvailableFlightViewModel
    {
        [DisplayName("Airline Name")]
        public string AirlineName { get; set; }

        public string Origin { get; set; }
        public string Destination { get; set; }

        [DisplayName("Flight Section Name")]
        public string FlightSectionName { get; set; }

        [DisplayName("Flight Id")]
        public string FlightId { get; set; }
    }
}