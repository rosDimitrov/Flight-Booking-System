using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABS.Util;
using ABS.Data;
using ABS.MVC.Models;
using ABS.Interfaces;

namespace ABS.MVC.Controllers
{
    public class SectionController : Controller
    {
        //UnitOfWork unitOfWork = new UnitOfWork();
        private ISectionManager sectionManager;

        public SectionController(ISectionManager sectionManager)
        {
            this.sectionManager = sectionManager;
        }

        // GET: Section/Create
        public ActionResult Create()
        {

            ViewBag.Sections = new List<SelectListItem>() {
                new SelectListItem() { Text="First",Value="First"},
                new SelectListItem(){ Text="Business",Value="Business"},
                new SelectListItem(){ Text="Economy",Value="Economy"}};

            return View();
        }

        // POST: Section/Create
        [HttpPost]
        public ActionResult Create(SectionViewModel section)
        {
            if (ModelState.IsValid)
            {
                //unitOfWork.SectionRepository.AddSection(
                this.sectionManager.AddSection(
                          section.AirlineName,
                          section.FlightId,
                          section.Rows,
                          section.Cols,
                          section.SectionType);
                //unitOfWork.Save();

                return RedirectToAction("Create", "Section");
            }
            return View(section);
        }


    }
}
