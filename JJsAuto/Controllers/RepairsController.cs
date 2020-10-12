using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JJsAuto.Models;

namespace JJsAuto.Controllers
{
    public class RepairsController : Controller
    {
        // GET: Repairs
        public ActionResult Index()
        {
            using (dbModel model = new dbModel())
            {
                return View(model.Repairs.ToList());
            }

        }

        // GET: Repairs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Repairs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repairs/Create
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

        // GET: Repairs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Repairs/Edit/5
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

        // GET: Repairs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Repairs/Delete/5
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
