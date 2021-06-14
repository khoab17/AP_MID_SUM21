using LabTask.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask.Controllers
{
    public class UMSController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            string uname = collection["UserName"];
            string pass = collection["Password"];
            Database db = new Database();

            var admin = db.Admins.Get(uname);
            if (admin == null)
            {
                ViewBag.error = "User not found";
                return View();
            }
            else
            {
                if (admin.UserName == uname && admin.Password == pass)
                {
                    ViewBag.logged = "yes";
                    //return View("Index", "Admin");
                   return RedirectToAction("Stuents", "Admin");
                }
                else
                {
                    ViewBag.error = "User name or Password error";
                    return View();
                }
            }
        }

    } 
}