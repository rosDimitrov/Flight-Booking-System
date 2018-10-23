using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABS.Data;
using ABS.MVC.Models;
using ABS.Interfaces;
namespace ABS.MVC.Controllers
{
    public class SystemController : Controller
    {
        //UnitOfWork unitOfWork = new UnitOfWork();
        // GET: System
        private IFlightManager flightManager;

        public SystemController(IFlightManager flightManager)
        {
            this.flightManager = flightManager;
        }
       
        public ActionResult DisplayDetails()
        {

            var flights = flightManager.DisplaySystemDetails();

            if (flights.Count() > 0)
            {
                List<SystemDetailsViewModel> model = new List<SystemDetailsViewModel>();

                foreach (var item in flights)
                {
                    model.Add(new SystemDetailsViewModel
                    {
                        AirlineName = item.AirlineName,
                        Origin = item.Origin,
                        Destination = item.Destination,
                        FlightId = item.FlightId,
                        FlightSectionName = item.FlightSectionName,
                        Row = item.Row,
                        Column = item.Column,
                        IsTaken = item.IsTaken
                    });
                }
                return View(model);
            }

            return View();

        }

    }
}
