using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABS.Util;
using ABS.MVC.Models;
using ABS.Data;
using ABS.Interfaces;

namespace ABS.MVC.Controllers
{
    public class SeatController : Controller
    {
        //UnitOfWork unitOfWork = new UnitOfWork();
        private ISeatManager seatManager;

        public SeatController(ISeatManager seatManager)
        {
            this.seatManager = seatManager;
        }

        public ActionResult BookSeat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookSeat(BookSeatViewModel seatToBook)
        {
            if (ModelState.IsValid)
            {
                //unitOfWork.SeatRepository.BookSeat(
                seatManager.BookSeat(
                    seatToBook.Airline,
                    seatToBook.FlightId,
                    seatToBook.SeatType,
                    seatToBook.Row,
                    seatToBook.Col);

                //unitOfWork.Save();

                TempData["Message"] = this.seatManager.Message;
                return RedirectToAction("BookSeat");
            }

            return View(seatToBook);
        }

    }
}
