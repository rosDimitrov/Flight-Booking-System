using ABS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABS.Model;
using ABS.Configuration;

namespace ABS.AppStart
{
    public class AppStart
    {
        public static void Main(string[] args)
        {



            SystemManager manager = new SystemManager();
            //Works
            //Console.WriteLine("-------------Airports-------------");
            //manager.CreateAirport("DEN");
            //manager.CreateAirport("DFW");
            //manager.CreateAirport("LON");
            //manager.CreateAirport("JPN");
            //manager.CreateAirport("DE");//should be invalid
            //manager.CreateAirport("DEH");
            //manager.CreateAirport("DEN");
            //manager.CreateAirport("NCE");
            //manager.CreateAirport("TRIord9");//should be invalid
            //manager.CreateAirport("DEN");


            ////Check
            //Console.WriteLine();
            //Console.WriteLine("-------------Airlines-------------");
            //manager.CreateAirline("DELTA");
            //manager.CreateAirline("AMER");
            //manager.CreateAirline("JET");
            //manager.CreateAirline("DELTA");
            //manager.CreateAirline("SWEST");
            //manager.CreateAirline("AMER");
            //manager.CreateAirline("FRONT");
            //manager.CreateAirline("FRONTIER");//should be invalid

            ////Check
            //Console.WriteLine();
            //Console.WriteLine("-------------Flights-------------");
            //manager.CreateFlight("DELTA", "DEN", "LON", 2009, 10, 10, "123");
            //manager.CreateFlight("DELTA", "DEN", "DEH", 2009, 8, 8, "567");
            //manager.CreateFlight("DELTA", "DEN", "NCE", 2010, 9, 8, "567");// should be invalid - Delata already has the id
            //manager.CreateFlight("JET", "LON", "DEN", 2009, 5, 7, "123");
            //manager.CreateFlight("AMER", "DEN", "LON", 2010, 10, 1, "123");
            //manager.CreateFlight("JET", "DEN", "LON", 2010, 6, 10, "786");
            //manager.CreateFlight("JET", "DEN", "LON", 2009, 1, 12, "909");



            //Add Section Types First, before the Creation of new Sections
           // Check
            //Console.WriteLine();
            //Console.WriteLine("-------------Sections-------------");
            //manager.CreateSection("JET", "123", 2, 2, "Economy");
            //manager.CreateSection("JET", "123", 1, 3, "Economy");
            //manager.CreateSection("JET", "123", 2, 3, "First");
            //manager.CreateSection("DELTA", "123", 1, 1, "Business");
            //manager.CreateSection("DELTA", "123", 1, 2, "Economy");
            //manager.CreateSection("SWSERTT", "123", 5, 5, "Economy");//invalid

            //manager.BookSeat("DELTA", "123", "Business", 1, 1);
            //manager.BookSeat("DELTA", "123", "Economy", 1, 1);
            //manager.BookSeat("DELTA", "123", "Economy", 1, 2);
            //manager.BookSeat("DELTA", "123", "Business", 1, 1);//should be booked already

            //Console.WriteLine();
            //Console.WriteLine("-------------Display System Details-------------");
            //manager.DisplaySystemDetails();


            //Console.WriteLine();
            //Console.WriteLine("-------------Find Available Flights-------------");
            ////two results because sections are created only for JET & DELTA Airlines, both with id:123
            //manager.FindAvailableFlights("DEN", "LON");


        }
    }
}
