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
    public class SeatRepository : ISeatRepository
    {
        private BookingSystemDbContext context;
        public SeatRepository()
        {
            this.context = new BookingSystemDbContext();
        }
        public SeatRepository(BookingSystemDbContext context)
        {
            this.context = context;
        }
        public void BookSeat(string airline, string flightId, string seatType, int row, int col)
        {            
            Airline targetAirline = context.Airlines.Where(a => a.AirlineName == airline).SingleOrDefault();
            Flight targetFlight = targetAirline.Flights.Where(f => f.FlightId == flightId).FirstOrDefault();
            FlightSection targetFlightSection = targetFlight.FlightSections.Where(s => s.FlightSectionType.FlightSectionName == seatType).FirstOrDefault();
            Seat targetSeat = targetFlightSection.Seats.Where(seat => seat.Row == row && seat.Column == col && seat.IsTaken == false).FirstOrDefault();

            targetSeat.IsTaken = true;
            context.SaveChanges();          
        }
        
        public bool AirlineExists(string airline)
        {
            return context.Airlines.Where(a => a.AirlineName == airline).Any();
        }
        public bool FlightExists(string airline,string flightId)
        {
            Airline targetAirline = context.Airlines.Where(a => a.AirlineName == airline).SingleOrDefault();
            return targetAirline.Flights.Where(f => f.FlightId == flightId).Any();
        }
        public bool FlightSectionExists(string airline,string flightId,string seatType)
        {
            Airline targetAirline = context.Airlines.Where(a => a.AirlineName == airline).SingleOrDefault();
            Flight targetFlight = targetAirline.Flights.Where(f => f.FlightId == flightId).FirstOrDefault();
            return targetFlight.FlightSections.Where(s => s.FlightSectionType.FlightSectionName == seatType).Any();
        }
        public bool SeatExistsAndNotTaken(string airline, string flightId, string seatType, int row, int col)
        {
            Airline targetAirline = context.Airlines.Where(a => a.AirlineName == airline).SingleOrDefault();
            Flight targetFlight = targetAirline.Flights.Where(f => f.FlightId == flightId).FirstOrDefault();
            FlightSection targetFlightSection = targetFlight.FlightSections.Where(s => s.FlightSectionType.FlightSectionName == seatType).FirstOrDefault();
            return targetFlightSection.Seats.Where(seat => seat.Row == row && seat.Column == col && seat.IsTaken == false).Any();
        }




    }
}
