using FindRoomMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindRoomMate.Controllers
{
    public class BrokersController : Controller
    {
        DataContext db = new DataContext();
        // GET: brokerss
        public ActionResult Index()
        {
            var broker = db.Brokers.ToList();
            return View(broker);
        }

        // GET: brokerss/Details/5
        public ActionResult Details(int id)
        {
            var broker = db.Brokers.Single(m => m.BrokerId == id);
            return View(broker);
        }

        // GET: brokerss/Create
        public ActionResult Create()
        {
            Broker broker = new Broker();
            broker.BrokerdateTime = DateTime.Now;
            return View(broker);
        }

        // POST: brokerss/Create
        [HttpPost]
        public ActionResult Create(Broker broker)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Brokers.Add(broker);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: brokerss/Edit/5
        public ActionResult Edit(int id)
        {
            var broker = db.Brokers.Single(m => m.BrokerId == id);

            return View();
        }

        // POST: brokerss/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Broker broker)
        {
            try
            {
                db.Entry(broker).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: brokerss/Delete/5
        public ActionResult Delete(int id)
        {
            var broker = db.Brokers.Single(m => m.BrokerId == id);

            return View();
        }

        // POST: brokerss/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Broker broker)
        {
            try
            {
                db.Entry(broker).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
