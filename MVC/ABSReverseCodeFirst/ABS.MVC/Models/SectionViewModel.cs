using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ABS.MVC.Models
{
    //CreateSection(string airlineName, string flightID, int rows, int cols, string sectionType)

    public class SectionViewModel
    {

        [DisplayName("Airline Name")]
        public string AirlineName { get; set; }

        [DisplayName("Flight Id")]
        public string FlightId { get; set; }

        public int Rows { get; set; }

        public int Cols { get; set; }

        [DisplayName("Section Type")]
        public string SectionType { get; set; }


    }
}