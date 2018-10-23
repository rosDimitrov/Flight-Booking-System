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
    public class AirportRepository : IAirportRepository
    {
        private BookingSystemDbContext context;


        public AirportRepository()
        {
            this.context = new BookingSystemDbContext();
        }

        public AirportRepository(BookingSystemDbContext context)
        {
            this.context = context;
        }

        public void AddAirport(string airportName)
        {
            context.Airports.Add(new Airport { AirportName = airportName });
            context.SaveChanges();
        }

        public bool AirportExists(string airportName)
        {
            return context.Airports.Where(x => x.AirportName == airportName).Any();
        }
    }
}
