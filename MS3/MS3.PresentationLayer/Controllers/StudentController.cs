using MS3.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MS3.PresentationLayer.Controllers
{
    public class StudentController : Controller
    {
        RespositoryModel respositoryModel = new RespositoryModel();
        
        public ActionResult DisplayStudent()
        {
            List<StudentModel> list = respositoryModel.DisplayStudent();
            //ViewBag.studentList = list;
            return View(list);
        }
        
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                respositoryModel.AddStudent(studentModel);
                return RedirectToAction("DisplayStudent");
            }
            return View();
        }
        [HttpGet]
        public ActionResult AssignStaff(int id)
        {
            StudentModel studentModel = respositoryModel.DisplayStudent().Single(stu => stu.Id ==id);
            return View(studentModel);
        }
        [HttpPost]
        [ActionName("AssignStaff")]
        public ActionResult AssignStaff_post(int id)
        {
            StudentModel studentModel = respositoryModel.DisplayStudent().Single(stu => stu.Id == id);
            UpdateModel(studentModel, new string[] { "StaffId" });
            if (ModelState.IsValid)
            {
                respositoryModel.AssignStaff(studentModel);
                return RedirectToAction("DisplayStudent");
            }
            return View(studentModel);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            StudentModel studentModel = respositoryModel.DisplayStudent().Single(stu => stu.Id == id);
            return View(studentModel);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post(int id)
        {
            respositoryModel.Delete(id);
            return RedirectToAction("DisplayStudent");
        }
    }
}