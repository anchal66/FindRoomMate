using FindRoomMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindRoomMate.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Employe
        public ActionResult Index()
        {
            var Models = new List<Employee>();
            var emp = new Employee();
            emp.FirstName = "Shrwan";
            emp.LastName = "kk";
            Models.Add(emp);
            return View(Models);
        }

        // GET: Employe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employe/Create
        [HttpPost]
        public ActionResult Create(FindRoomMate.Models.Employee collection)
         {
            try
            {
                // TODO: Add insert logic here
                ViewBag.isSuccess = true;
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Employe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employe/Edit/5
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

        // GET: Employe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employe/Delete/5
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
