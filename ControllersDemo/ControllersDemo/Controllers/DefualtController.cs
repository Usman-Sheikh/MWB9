using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersDemo.Controllers
{
    public class DefualtController : Controller
    {
        // GET: Defualt
        public ActionResult Index()
        {
            return View();
        }

        // GET: Defualt/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Defualt/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Defualt/Create
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

        // GET: Defualt/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Defualt/Edit/5
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

        // GET: Defualt/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Defualt/Delete/5
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
