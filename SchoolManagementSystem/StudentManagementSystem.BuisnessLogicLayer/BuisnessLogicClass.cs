using SchoolManagementSystem.EntityLayer;
using StudentManagementSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BuisnessLogicLayer
{
    public class BuisnessLogicClass
    {
        DbClass dbClass = new DbClass();
        public int AddTeacher(Teacher teacher)
        {
            return dbClass.AddTeacher(teacher);
        }

        public int AddStudent(Student student)
        {
            return dbClass.AddStudent(student);
        }

        public List<Student> SearchStudent(int id, Student student)
        {
            return dbClass.SearchStudent(id, student);
        }

        public List<Teacher> SearchTeacher(int id, Teacher teacher)
        {
            return dbClass.SearchTeacher(id, teacher);
        }

        public List<string> NumberOfStudents(int id)
        {
            return dbClass.NumberOfStudents(id);
        }
    }
}
