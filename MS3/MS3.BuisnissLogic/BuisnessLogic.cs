using MS3.Database;
using MS3.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS3.BuisnissLogic
{
    public class BuisnessLogic
    {
        DataBase databaseLayer = new DataBase();

        public void AddStudent(Student student)
        {
            databaseLayer.AddStudent(student);
        }
        public List<Student> StudentBasedOnStaff(int staffId)
        {
            return databaseLayer.StudentBasedOnStaff(staffId);
        }

        public void Update(int id, string number, string mailId)
        {
            databaseLayer.Update(id, number, mailId);
        }
        public void Delete(int id)
        {
            databaseLayer.Delete(id);
        }

        public List<Student> DisplayStudent()
        {
            return databaseLayer.DisplayStudent();
        }

        public List<Staff> DisplayStaff()
        {
            return databaseLayer.DisplayStaff();
        }

        public Student DisplayById(int id)
        {
            return databaseLayer.DisplayById(id);
        }

        public void AssignStaff(Student student)
        {
            databaseLayer.AssignStaff(student);
        }
    }
}