using MS3.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MS3.PresentationLayer.Controllers
{
    public class StaffController : Controller
    {
        RespositoryModel respositoryModel = new RespositoryModel();
        // GET: Staff
        public ActionResult DisplayStaff()
        {
            List<StaffModel> list = respositoryModel.DisplayStaff();
            
            return View(list);
            
        }

        public ActionResult DisplayStudentOnStaff(int id)
        {
            List<StudentModel> list = respositoryModel.StudentBasedOnStaff(id);
            return View(list);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            StaffModel staffModel = respositoryModel.DisplayStaff().Single(m => m.StaffId == id);
            return View(staffModel);
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditPost(int id)
        {
            StaffModel staffModel = respositoryModel.DisplayStaff().Single(m => m.StaffId == id);
            UpdateModel(staffModel,new string[] { "ContactNumber","EmailId"});
            if (ModelState.IsValid)
            {
                respositoryModel.Update(staffModel.StaffId, staffModel.ContactNumber, staffModel.EmailId);
                return RedirectToAction("DisplayStaff");
            }
            return View(staffModel);
        }
    }
}