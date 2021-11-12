using MS3.BuisnissLogic;
using MS3.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS3.PresentationLayer.Models
{
    public class RespositoryModel
    {
        BuisnessLogic buisnessLogic = new BuisnessLogic();
        public void AddStudent(StudentModel studentModel)
        {
            Student student = new Student()
            {
                Id = studentModel.Id,
                Name = studentModel.Name,
                DOB = studentModel.DOB,
                ContactNumer = studentModel.ContactNumer,
                Address = studentModel.Address,
                StaffId = studentModel.StaffId
            };
            buisnessLogic.AddStudent(student);
        }

        public List<StaffModel> DisplayStaff()
        {
            List<Staff> sList = buisnessLogic.DisplayStaff();
            List<StaffModel> list = new List<StaffModel>();
            foreach (Staff staff in sList)
            {
                StaffModel staffModel = new StaffModel
                {
                    StaffId=staff.StaffId,
                    StaffName = staff.StaffName,
                    EmailId = staff.EmailId,                    
                    ContactNumber = staff.ContactNumber,
                    ClassType = staff.ClassType
                };
                list.Add(staffModel);
            }
            return list;
        }

        public List<StudentModel> DisplayStudent()
        {
            List<Student> sList= buisnessLogic.DisplayStudent();
            List<StudentModel> list = new List<StudentModel>();
            foreach(Student student in sList)
            {
                StudentModel studentModel = new StudentModel
                {
                    Name = student.Name,
                    Id = student.Id,
                    Address=student.Address,
                    ContactNumer=student.ContactNumer,
                    DOB=student.DOB
                };
                list.Add(studentModel);
            }
            return list;
        }
        public List<StudentModel> StudentBasedOnStaff(int staffId)
        {
            List<Student> slist=buisnessLogic.StudentBasedOnStaff(staffId);
            List<StudentModel> list = new List<StudentModel>();
            foreach(Student student in slist)
            {
                StudentModel studentModel = new StudentModel()
                {
                    Name = student.Name,
                    Id = student.Id,
                    Address = student.Address,
                    ContactNumer = student.ContactNumer,
                    DOB = student.DOB
                };
                list.Add(studentModel);
            }
            return list;
        }

        public void Update(int id, string number, string mailId)
        {
            buisnessLogic.Update(id, number, mailId);
        }

        internal void AssignStaff(StudentModel studentModel)
        {
            Student student = new Student()
            {
                Id=studentModel.Id,
                Name=studentModel.Name,
                Address=studentModel.Address,
                DOB=studentModel.DOB,
                ContactNumer=studentModel.ContactNumer,
                StaffId=studentModel.StaffId
            };
            buisnessLogic.AssignStaff(student);
        }

        public void Delete(int id)
        {
            buisnessLogic.Delete(id);
        }
        public StudentModel DisplayById(int id)
        {

            Student student=buisnessLogic.DisplayById(id);
            StudentModel studentModel = new StudentModel
            {
                Name = student.Name,
                Id = student.Id,
                Address = student.Address,
                ContactNumer = student.ContactNumer,
                DOB = student.DOB
            };
            return studentModel;
        }
    }
}