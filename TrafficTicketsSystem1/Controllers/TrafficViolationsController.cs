using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrafficTicketsSystem10.Controllers
{
    public class TrafficViolationsController : Controller
    {
        // GET: TrafficViolations
        public ActionResult Index()
        {
            return View();
        }

        // GET: TrafficViolations/Details/5
        public ActionResult Details(int? id)
        {
            return View();
        }

        // GET: TrafficViolations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrafficViolations/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TrafficViolations/Edit/5
        public ActionResult Edit(int ?id)
        {
            return View();
        }

        // POST: TrafficViolations/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TrafficViolations/Delete/5
        public ActionResult Delete(int? id)
        {
            return View();
        }

        // POST: TrafficViolations/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
