using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindRoomMate.Models;

namespace FindRoomMate.Controllers
{
    public class BrokersController : Controller
    {
        // GET: Brokers
        public ActionResult FindBroker()
        {
            return View();
        }
        
        public ActionResult New()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Broker broker)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Index");
            else
                return RedirectToAction("New");
        }

    }
}