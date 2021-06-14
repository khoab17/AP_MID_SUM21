using LabTask.Models;
using LabTask.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Students()
        {
            Database db = new Database();
            var students = db.Students.GetALL();
            
            return View(students);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            Database db = new Database();
            var departments = db.Departments.GetALL();
            ViewBag.departments = departments;
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(Student student )
        {
            Database db = new Database();
            db.Students.Insert(student);
            return RedirectToAction("Students");
        }


        [HttpGet]
        public ActionResult EditStudent(int id)
        {
            Database db = new Database();
            var student = db.Students.Get(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult EditStudent(Student student)
        {
            Database db = new Database();
            db.Students.Edit(student);
            return RedirectToAction("Students");
        }

        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Students.Delete(id);
            return RedirectToAction("Students");
        }



        /// Department
        public ActionResult Departments()
        {
            Database db = new Database();
            var departments = db.Departments.GetALL();
            return View(departments);
        }
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            Database db = new Database();
            db.Departments.Insert(department);
            return RedirectToAction("Departments");

        }
    }
}