using Lab_Practice.Models;
using Lab_Practice.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_Practice.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            Database db = new Database();
            var department=db.Departments.GetAll();
            return View(department);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department d)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Departments.Insert(d);
                return RedirectToAction("Index", "department");
            }
            else
                return View();   
        }

        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var department=db.Departments.Get(id);
            return View(department);
        }
        [HttpPost]
        public ActionResult Edit(Department d)
        {
            if(ModelState.IsValid)
            {
                Database db = new Database();
                db.Departments.Update(d);
                return RedirectToAction("Index", "Department");
            }
            else
            {
                Database db = new Database();
                var department= db.Departments.Get(d.Id);
                return View(department);
            }
        }

        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Departments.Delete(id);
            return RedirectToAction("Index", "Department");
        }
    }
}