using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOwnCode
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails obj = new EmployeeDetails();
            List<EmployeeDetails> list = new List<EmployeeDetails>();
            int exit = 1,choice;
            Console.WriteLine("****Welcome To Employee Management System****");
            while (exit == 1)
            {
                Console.WriteLine("1)	Add a new employee id, name, salary, address\n 2)	List all Employee with name, Id \n 3)	Search Employee with ID\n 4)	Edit Employee by ID\n 5)	Delete Employee by ID\n 6)	Exit");
                Console.WriteLine("Enter Choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddDetails(list,obj);
                        break;
                    case 2:
                        Display(list);
                        break;
                    case 3:
                        Console.WriteLine("Enter id to search");
                        A: int id = Convert.ToInt32(Console.ReadLine());
                        EmployeeDetails searchObj=search( list,id);
                        if (searchObj != null)
                        {
                            Console.WriteLine("Employee id: "+searchObj.EmployeeId);
                            Console.WriteLine("Employee Name: "+searchObj.EmployeeName);
                            Console.WriteLine("Employee Address: "+searchObj.Address);
                            Console.WriteLine("Emplyee salary: "+searchObj.Salary);
                        }
                        else
                        {
                            try
                            {
                                throw new IdNotFoundException("Enter valid id");
                            }
                            catch(IdNotFoundException ex)
                            {
                                goto A;
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter id to search and delete");
                        B: int modid = Convert.ToInt32(Console.ReadLine());
                        EmployeeDetails modObj = search(list, modid);
                        if (modObj != null)
                        {
                            Modify(modObj);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter id to search and delete");
                        C: int delid = Convert.ToInt32(Console.ReadLine());
                        EmployeeDetails delObj = search(list, delid);
                        if (delObj == null)
                        {
                            try
                            {
                                throw new IdNotFoundException("Enter valid id");
                            }
                            catch (IdNotFoundException ex)
                            {
                                goto C;
                                Console.WriteLine(ex.Message);
                            }
                        }
                        list.Remove(delObj);
                        break;
                    case 6:
                        exit = 0;
                        break;
                }
            }
        }

        private static void Modify(EmployeeDetails modObj)
        {
            int choice;
            Console.WriteLine("1.Id\n2.Name\n3.Address\n4.salary");
            Console.WriteLine("Enter choice");
            s: choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter new Id");
                    modObj.EmployeeId = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter new Name");
                    modObj.EmployeeName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter new Address");
                    modObj.Address = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter new Salary");
                    modObj.Salary = Convert.ToDouble(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    goto s;
            }
        }

        private static EmployeeDetails search( List<EmployeeDetails> obj,int id)
        {
           foreach(EmployeeDetails i in obj)
            {
                if (i.EmployeeId == id)
                    return i;
            }
            return null;
        }

        private static void Display(List<EmployeeDetails> list)
        {
            Console.WriteLine("Employee Id    Employee Name");
            foreach (EmployeeDetails i in list)
            {
                Console.WriteLine("{0}          {1}",i.EmployeeId,i.EmployeeName);
            }
        }

        private static void AddDetails(List<EmployeeDetails> list,EmployeeDetails obj)
        {
            Console.WriteLine("Enter employee id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            obj = new EmployeeDetails(id, name, address, salary);
            list.Add(obj);
        }
    }

    [Serializable]
    internal class IdNotFoundException : Exception
    {
        public IdNotFoundException()
        {
        }

        public IdNotFoundException(string message) : base(message)
        {
        }

        public IdNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IdNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
