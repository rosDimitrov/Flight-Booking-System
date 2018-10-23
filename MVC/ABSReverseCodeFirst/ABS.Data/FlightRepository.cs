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
    public class FlightRepository : IFlightRepository
    {
        private BookingSystemDbContext context;
        public FlightRepository()
        {
            this.context = new BookingSystemDbContext();
        }
        public FlightRepository(BookingSystemDbContext context)
        {
            this.context = context;
        }

        public void AddFlight(string airlineName, string origin, string destination, int year, int month, int day, string flightId)
        {
            Airline targetAirline = context.Airlines.Where(x => x.AirlineName == airlineName).FirstOrDefault();
            Airport originAirport = context.Airports.Where(x => x.AirportName == origin).FirstOrDefault();
            Airport destinationAirport = context.Airports.Where(x => x.AirportName == destination).FirstOrDefault();
            Flight targetFlight = targetAirline.Flights.Where(x => x.FlightId == flightId).FirstOrDefault();

            context.Flights.Add(new Flight() { Airline = targetAirline, Origin = originAirport, Destination = destinationAirport, FlightId = flightId, DepartureDate = new DateTime(year, month, day) });
            context.SaveChanges();
        }

        public bool AirlineExists(string airlineName)
        {
            return context.Airlines.Where(x => x.AirlineName == airlineName).Any();
        }
        public bool AirportExists(string airportName)
        {
            return context.Airports.Where(x => x.AirportName == airportName).Any();
        }
        public bool FlightExists(string airlineName, string flightId)
        {
            Airline targetAirline = context.Airlines.Where(x => x.AirlineName == airlineName).FirstOrDefault();
            return targetAirline.Flights.Where(x => x.FlightId == flightId).Any();
        }



        public IEnumerable<SpFindAvailableFlightsBetweenReturnModel> FindAvailableFlights(string origin, string destination)
        {
            return context.SpFindAvailableFlightsBetween(origin, destination).ToList();
        }

        public IEnumerable<VFlightsInformation> DisplaySystemDetails()
        {
            return context.VFlightsInformations.ToList();
        }
    }
}
