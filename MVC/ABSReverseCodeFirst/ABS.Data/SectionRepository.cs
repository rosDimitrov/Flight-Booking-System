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
    public class SectionRepository : ISectionRepository
    {
        private BookingSystemDbContext context;
        public SectionRepository()
        {
            this.context = new BookingSystemDbContext();
        }
        public SectionRepository(BookingSystemDbContext context)
        {
            this.context = context;
        }

        public void AddSection(string airlineName, string flightId, int rows, int cols, string sectionType)
        {

            Airline targetAirline = context.Airlines.Where(x => x.AirlineName == airlineName).FirstOrDefault();
            Flight targetFlight = targetAirline.Flights.Where(x => x.FlightId == flightId).FirstOrDefault();
            var flightSection = targetFlight.FlightSections.Where(x => x.FlightSectionType.FlightSectionName == sectionType).FirstOrDefault();


            if (targetAirline != null)
            {
                if (targetFlight != null)
                {
                    //if no such class in the flight exists,create one
                    if (flightSection == null)
                    {
                        HashSet<Seat> sectionSeats = new HashSet<Seat>();
                        for (int i = 1; i <= rows; i++)
                        {
                            for (int j = 1; j <= cols; j++)
                            {
                                sectionSeats.Add(new Seat() { Row = i, Column = j, IsTaken = false });
                            }
                        }
                        var section = context.FlightSectionTypes.Where(x => x.FlightSectionName == sectionType).FirstOrDefault();
                        targetFlight.FlightSections.Add(new FlightSection() { Seats = sectionSeats, FlightSectionType = section });
                    }
                    context.SaveChanges();
                }
            }
        }

        public bool AirlineExists(string airlineName)
        {
            return context.Airlines.Where(x => x.AirlineName == airlineName).Any();
        }

        public bool FlightExists(string airlineName,string flightId)
        {
            Airline targetAirline = context.Airlines.Where(x => x.AirlineName == airlineName).FirstOrDefault();
            return targetAirline.Flights.Where(x => x.FlightId == flightId).Any();
        }
        public bool FlightSectionTypeExists(string airlineName,string flightId,string sectionType)
        {
            Airline targetAirline = context.Airlines.Where(x => x.AirlineName == airlineName).FirstOrDefault();
            Flight targetFlight = targetAirline.Flights.Where(x => x.FlightId == flightId).FirstOrDefault();
            return targetFlight.FlightSections.Where(x => x.FlightSectionType.FlightSectionName == sectionType).Any();
        }


    }
}
