using MS3.Entity;
using MS3.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MS3.PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        RespositoryModel respositoryModel = new RespositoryModel();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            if (ModelState.IsValid && (admin.Password.Equals(admin.PasswordTest)&&admin.Username.Equals(admin.UsernameTest)))
            {
                return RedirectToAction("DisplayStudent", "Student");
            }
            return View(admin);
        }
        

    }
}

