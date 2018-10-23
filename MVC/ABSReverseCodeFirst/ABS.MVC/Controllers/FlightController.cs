using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABS.Data;
using ABS.Util;
using ABS.Model;
using ABS.MVC.Models;
using ABS.Interfaces;

namespace ABS.MVC.Controllers
{
    public class FlightController : Controller
    {
        //private UnitOfWork unitOfWork = new UnitOfWork();
        private IFlightManager flightManager;

        public FlightController(IFlightManager flightManager)
        {
            this.flightManager = flightManager;
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FlightViewModel flight)
        {
            
            if (ModelState.IsValid)
            {

                //unitOfWork.FlightRepository.AddFlight(
                flightManager.AddFlight(
                    flight.AirlineName,
                    flight.Origin,
                    flight.Destination,
                    flight.Year,
                    flight.Month,
                    flight.Day,
                    flight.FlightId);
                //unitOfWork.Save();
                TempData["Message"] = this.flightManager.Message;
                return RedirectToAction("Create", "Flight");
            }
            return View(flight);
        }

        public ActionResult FindAvailableFlights()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FindAvailableFlights(FlightRouteViewModel route)
        {
            if (ModelState.IsValid)
            {
                var flights = flightManager.FindAvailableFlights(route.Origin, route.Destination);

                if (flights.Count() > 0)
                {
               
                List<AvailableFlightViewModel> availableFlights = new List<AvailableFlightViewModel>();

                foreach (var flight in flights)
                {
                    availableFlights.Add(new AvailableFlightViewModel
                    {
                        AirlineName = flight.AirlineName,
                        Origin = flight.Origin,
                        Destination = flight.Destination,
                        FlightId = flight.FlightId,
                        FlightSectionName = flight.FlightSectionName
                    });
                }
                    return View("Index", availableFlights);
                }
                
                    
                
            }

            return View(route);


        }




    }
}
