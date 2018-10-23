using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ABS.MVC.Models
{
    public class AirportViewModel
    {
        [DisplayName("Airport Name")]
        public string AirportName { get; set; }
        
    }
}