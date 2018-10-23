using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABS.Model;
using ABS.Data;
using ABS.Util;
using ABS.MVC.Models;
using ABS.Interfaces;

namespace ABS.MVC.Controllers
{
    public class AirportController : Controller
    {
        //private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: Airport

        private IAirportManager airportManager;

        public AirportController(IAirportManager airportManager)
        {
            this.airportManager = airportManager;
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AirportViewModel airport)
        {
            //Can be only 3 symbols - to change it in the VIEW 
            if (ModelState.IsValid)
            {
                airportManager.AddAirport(airport.AirportName);

                //unitOfWork.AirportRepository.AddAirport(airport.AirportName);
                //unitOfWork.Save();
                TempData["Message"] = this.airportManager.Message;
                return RedirectToAction("Create", "Airport");
            }
            return View(airport);          
        }

    }
}