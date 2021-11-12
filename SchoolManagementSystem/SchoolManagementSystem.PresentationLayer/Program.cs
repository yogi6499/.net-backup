using SchoolManagementSystem.EntityLayer;
using StudentManagementSystem.BuisnessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.PresentationLayer
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            BuisnessLogicClass buisnessLogicClass = new BuisnessLogicClass();
            int exit = 1,choice;
            while (exit == 1)
            {
                Console.WriteLine("1.Add Teacher\n2.Add Student\n3.search student by id\n4.search teacher by id\n5.find number of student thought by teacher\n6.Exit");
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddTeacher();
                        
                        break;
                    case 2:
                        AddStudent();
                        break;
                    case 3:
                        SearchStudent();
                        break;
                    case 4:
                        SearchTeacher();
                        break;
                    case 5:
                        NumberOfStudents();
                        break;
                    case 6:
                        exit = 0;
                        break;
                }
            }
            Console.ReadLine();
        }

        private static void NumberOfStudents()
        {
            BuisnessLogicClass buisnessLogicClass = new BuisnessLogicClass();
            Console.WriteLine("Enter teacher id to find number of students");
            int id = Convert.ToInt32(Console.ReadLine());
            List<string> list=buisnessLogicClass.NumberOfStudents(id);
            foreach(string str in list)
                Console.WriteLine(str);
        }

        private static void SearchTeacher()
        {
            Teacher teacher = new Teacher();
            BuisnessLogicClass buisnessLogicClass = new BuisnessLogicClass();
            Console.WriteLine("Enter Teacher id to search");
            int id = Convert.ToInt32(Console.ReadLine());
            List<Teacher> list = buisnessLogicClass.SearchTeacher(id, teacher);
            foreach (Teacher detail in list)
                Console.WriteLine(detail.Id + " " + detail.Name + " " + detail.Gender + " Salary:" + detail.Salary+" Subject"+detail.Subject);
        }

        private static void SearchStudent()
        {
            Student student = new Student();
            BuisnessLogicClass buisnessLogicClass = new BuisnessLogicClass();
            Console.WriteLine("Enter student id to search");
            int id = Convert.ToInt32(Console.ReadLine());
            List<Student> list=buisnessLogicClass.SearchStudent(id,student);
            foreach(Student detail in list)
                Console.WriteLine(detail.Id+" "+detail.Name+" "+detail.Gender+" Age:"+detail.Age);
        }

        private static void AddStudent()
        {
            Student student = new Student();
            BuisnessLogicClass buisnessLogicClass = new BuisnessLogicClass();
            Console.WriteLine("Enter student name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter age");
            student.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter TeacherId teaches student");
            student.TeacherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter gender");
            student.Gender = Console.ReadLine();
            int rowsAffected = buisnessLogicClass.AddStudent(student);
            Console.WriteLine();
            Console.WriteLine(rowsAffected + " rows affected");
        }

        private static void AddTeacher()
        {
            Teacher teacher = new Teacher();
            BuisnessLogicClass buisnessLogicClass = new BuisnessLogicClass();
            Console.WriteLine("Enter teacher name:");
            teacher.Name = Console.ReadLine();
            Console.WriteLine("Enter subject");
            teacher.Subject = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            teacher.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter gender");
            teacher.Gender = Console.ReadLine();
            int rowsAffected = buisnessLogicClass.AddTeacher(teacher);
            Console.WriteLine();
            Console.WriteLine(rowsAffected+" rows affected");
        }
    }
}
