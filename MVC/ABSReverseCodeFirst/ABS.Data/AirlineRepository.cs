using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Model;
using ABS.Interfaces;
using ABS.Util;

namespace ABS.Data
{
    public class AirlineRepository : IAirlineRepository
    {
        private BookingSystemDbContext context;

        public AirlineRepository()
        {
            this.context = new BookingSystemDbContext();
        }
        public AirlineRepository(BookingSystemDbContext context)
        {
            this.context = context;
        }
        public void AddAirline(string airlineName)
        {
            context.Airlines.Add(new Airline { AirlineName = airlineName });
            context.SaveChanges();
        }

        public bool AirlineExists(string airlineName)
        {
            return context.Airlines.Where(x => x.AirlineName == airlineName).Any();
        }

    }
}
