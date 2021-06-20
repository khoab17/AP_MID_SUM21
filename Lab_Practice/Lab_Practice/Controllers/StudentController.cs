using Lab_Practice.Models;
using Lab_Practice.Models.Database;
using Lab_Practice.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_Practice.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            Database db = new Database();
            var students=db.Students.GetALL();
            List<Department> dept = db.Departments.GetAll();
            foreach(var item in students)
            {
                foreach(var i in dept)
                {
                    if(item.Dept_id==i.Id)
                    {
                        Department department = new Department();
                        department.Id = i.Id;
                        department.Name = i.Name;
                        item.Department = department;
                    }
                }
            }
            return View(students);
        }

        public ActionResult Create()
        {
            Student s = new Student();
            Database db = new Database();
            StudentDepartment combodata = new StudentDepartment();
            combodata.departments = db.Departments.GetAll();
            return View(combodata);
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(s);
                return RedirectToAction("Index");
            }
            else
            {
                Database database = new Database();
                StudentDepartment combodata = new StudentDepartment();
                combodata.departments = database.Departments.GetAll();
                return View(combodata);
            }
                
        }

        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var st=db.Students.Get(id);
            StudentDepartment sd = new StudentDepartment();
            List<Department> dept = db.Departments.GetAll();
            sd.student = st;
            sd.departments = dept;
            return View(sd);
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if(ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Update(s);
                return RedirectToAction("Index");
            }
            else
            {
                Database db = new Database();
                var student = db.Students.Get(s.Id);
                return View(student);
            }        
        }

        public ActionResult Delete(int id)
        {
            Database d = new Database();
            d.Students.Delete(id);
            return RedirectToAction("Index");
        }
    }
}