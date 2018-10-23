using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABS.Data;
using ABS.Model;
using ABS.Util;
using ABS.MVC.Models;
using ABS.Interfaces;

namespace ABS.MVC.Controllers
{
    public class AirlineController : Controller
    {
        private IAirlineManager airlineManager;
        public AirlineController(IAirlineManager airlineManager)
        {
            this.airlineManager = airlineManager;
        }

        //UnitOfWork unitOfWork = new UnitOfWork();
        // GET: Airline
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AirlineViewModel airline)
        {
            if(ModelState.IsValid)
            {
                airlineManager.AddAirline(airline.AirlineName);

                //unitOfWork.AirlineRepository.AddAirline(airline.AirlineName);
                //unitOfWork.Save();

                TempData["Message"] = this.airlineManager.Message;
                return RedirectToAction("Create","Airline");
            }
            return View(airline);

        }
    }
}