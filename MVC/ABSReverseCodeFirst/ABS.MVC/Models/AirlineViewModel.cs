using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ABS.MVC.Models
{
    public class AirlineViewModel
    {
        [DisplayName("Airline Name")]
        public string AirlineName { get; set; }
        
    }
}