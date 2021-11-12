using MilestoneAssesment2.BuisnessLogicLayer;
using MilestoneAssesment2.CustomExceptionLayer;
using MilestoneAssesment2.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneAssesment2.PresentationLayer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int exit = 1, choice;
            while (exit == 1)
            {
                Console.WriteLine("1. Creating employee.\n2.Applying Leave.\n3.Fetch all leaves with employee name associated, by employee id\n4.Delete leave by leave id.\n5.Delete employee by employee id.\n6.Exit");
                Console.WriteLine("Enter choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ApplyLeave();
                        break;
                    case 3:
                        GetLeave();
                        break;
                    case 4:
                        DeleteLeave();
                        break;
                    case 5:
                        DeleteEmployee();
                        break;
                    case 6:
                        exit = 0;
                        break;
                }

            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        private static void DeleteEmployee()
        {
            Employee employee = new Employee();
            BuisnessLogic buisnessLogic = new BuisnessLogic();
            Console.WriteLine("Enter Employee id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            bool boolLeave = buisnessLogic.DeleteEmployee(id);
            if (boolLeave)
            {
                Console.WriteLine("Successfully deleated");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private static void DeleteLeave()
        {
            Leave leave = new Leave();
            BuisnessLogic buisnessLogic = new BuisnessLogic();
            Console.WriteLine("Enter leave id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            bool boolLeave=buisnessLogic.DeleteLeave(id);
            if (boolLeave)
            {
                Console.WriteLine("Successfully deleated");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

        }

        private static void GetLeave()
        {
            Employee employee = new Employee();
            BuisnessLogic buisnessLogic = new BuisnessLogic();
            Console.WriteLine("Enter Employee Id");
            int id = Convert.ToInt32(Console.ReadLine());
            List<string> list = buisnessLogic.GetLeave(id);
            foreach(string details in list)
                Console.WriteLine(details);
        }

        private static void ApplyLeave()
        {
            Leave leave = new Leave();
            BuisnessLogic buisnessLogic = new BuisnessLogic();
            Console.WriteLine("Enter Employee Id");
            leave.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter FromDate:");
            leave.FromDate = Console.ReadLine();
            Console.WriteLine("Enter ToDate");
            leave.ToDate = Console.ReadLine();
            Console.WriteLine("Enter FromSession");
            leave.FromSession = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter TSession"); ;
            leave.ToSession= Convert.ToInt32(Console.ReadLine());
           
                bool rowsAffected = buisnessLogic.ApplyLeave(leave);
            
           
            if (rowsAffected)
            {
                Console.WriteLine("Successfully Added");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private static void AddEmployee()
        {
            Employee employee = new Employee();
            BuisnessLogic buisnessLogic = new BuisnessLogic();
            Console.WriteLine("Enter Employee Name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Address:");
            employee.Address = Console.ReadLine();
            Console.WriteLine("Enter Enployee emailid:");
            employee.EmailId = Console.ReadLine();
            Console.WriteLine("Enter Join date:");
            employee.JoiningDate = Console.ReadLine();
            Console.WriteLine("Enter Contact Number:");
            employee.ContactNumber = Console.ReadLine();
            try
            {
                bool rowsAffected = buisnessLogic.AddEmployee(employee);
                if (rowsAffected)
                {
                    Console.WriteLine("Successfully Added");
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }
            catch (DuplicateEmailIDException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
