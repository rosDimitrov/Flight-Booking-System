using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Data;
using ABS.Model;
using ABS.Interfaces;
using ABS.Util;

namespace ABS.AppStart
{
    public class SystemManager
    {
        //private Validator Validator { get; set; }
        //private Seeder seeder;
        //private UnitOfWork unitOfwork;
        //public SystemManager()
        //{
        //    this.unitOfwork = new UnitOfWork();
        //    this.Validator = new Validator();
        //    this.seeder = new Seeder();
        //    seeder.AddSectionTypes();
        //}


        ////Check
        //public void CreateAirport(string airportName)
        //{
        //    if (Validator.ValidateAirportName(airportName))
        //    {
        //        unitOfwork.AirportRepository.AddAirport(airportName);
        //        unitOfwork.Save();
        //    }

        //}

        ////Check
        //public void CreateAirline(string airlineName)
        //{
        //    if (Validator.ValidateAirlineName(airlineName))
        //    {
        //        unitOfwork.AirlineRepository.AddAirline(airlineName);
        //        unitOfwork.Save();
        //    }
        //}

        ////Check
        //public void CreateFlight(string airlineName, string origin, string destination, int year, int month, int day, string id)
        //{
        //    if (Validator.ValidateFlightRoute(origin, destination) && Validator.ValidateDate(year, month, day))
        //    {
        //        unitOfwork.FlightRepository.AddFlight(airlineName, origin, destination, year, month, day, id);
        //        unitOfwork.Save();
        //    }
        //}

        ////Check
        //public void CreateSection(string airlineName, string flightID, int rows, int cols, string sectionType)
        //{

        //    if (Validator.ValidateFlightSectionRowsCols(rows, cols))
        //    {
        //        unitOfwork.SectionRepository.AddSection(airlineName, flightID, rows, cols, sectionType);
        //        unitOfwork.Save();
        //    }
        //}

        ////Check
        //public void FindAvailableFlights(string orig, string dest)
        //{
        //    if (Validator.ValidateFlightRoute(orig, dest))
        //    {
        //        var flighs = unitOfwork.FlightRepository.FindAvailableFlights(orig, dest);
        //        foreach (var item in flighs)
        //        {
        //            Console.WriteLine($"{item.AirlineName} {item.Origin}-{item.Destination} {item.FlightId} {item.FlightSectionName}");
        //        }
        //    }

        //}

        ////Check
        //public void BookSeat(string airline, string flightID, string seatType, int row, int col)
        //{
        //    unitOfwork.SeatRepository.BookSeat(airline, flightID, seatType, row, col);
        //    unitOfwork.Save();
        //}


        ////
        //public void DisplaySystemDetails()
        //{

        //    IEnumerable<VFlightsInformation> flights = unitOfwork.FlightRepository.DisplaySystemDetails();


        //    Console.WriteLine("--------------------------LIST OF ALL AIRLINES AND THEIR DETAILS:");

        //    foreach (var flight in flights)
        //    {
        //        Console.WriteLine(flight.AirlineName);
        //        Console.WriteLine($"{flight.Origin}-{flight.Destination} {flight.FlightId}");
        //        Console.WriteLine($"{flight.FlightSectionName}-{flight.Row}/{flight.Column} Taken:{flight.IsTaken}");
        //    }
        //}



    }


}

