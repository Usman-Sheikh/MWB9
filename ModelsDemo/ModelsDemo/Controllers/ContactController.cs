using ModelsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelsDemo.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactMessage message)
        {
            if(!ModelState.IsValid)
            {
                return View(message);
            }
            return View();
        }
    }
}