using Lab_Practice.Models;
using Lab_Practice.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Lab_Practice.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            Admin admin = new Admin();
            return View(admin);
        }

        [HttpPost]
        public ActionResult Index(Admin a)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                Admin admin;
                admin = db.Admins.Get(a.UserName, a.Password);
                if (admin != null)
                {
                    FormsAuthentication.SetAuthCookie(a.Name, false);
                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    ViewData["error"] = "Invalid Username or Password";
                    return View(a);
                }
            }
            else
            {
                return View(a);
            }
        }
                

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }
    }
}