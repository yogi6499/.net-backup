using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_system
{
    class EmployeeManagement
    {
        public void AddEmployee(List<Employee> employeeList)
        {
            Employee obj_Comapny1 = new Employee();
            Console.Write("Enter Employee Id:");
            obj_Comapny1.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            obj_Comapny1.EmployeeName = Console.ReadLine();
            Console.Write("Enter Employee Addess:");
            obj_Comapny1.Address = Console.ReadLine();
            Console.Write("Enter Employee Salary:");
            obj_Comapny1.Salary = Convert.ToDouble(Console.ReadLine());

            employeeList.Add(obj_Comapny1);
            Console.WriteLine("Employee Deatil Added Successfully...!!!!:");
            Console.ReadLine();
        }

        public void DisplayEmployee(List<Employee> employeeList)
        {
            Console.WriteLine("****************************Employee Details****************************************");

            Console.WriteLine("Employee Id    Employee Name");

            foreach (Employee i in employeeList)
            {
                Console.WriteLine("{0}            {1}", i.EmployeeId, i.EmployeeName);
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.ReadLine();
        }

        public Employee Search(List<Employee> employeeList, int search_Id)
        {
            return employeeList.Find(emp => emp.EmployeeId == search_Id);
            
        }


        public void ModifyEmployee(List<Employee> employeeList, Employee obj_Modify)
        {

            Console.WriteLine("Chose Option for Modify Employee Detail:");
            Console.WriteLine("1.Id 2.Name 3.Address 4.Salary");
            int modify_number = Convert.ToInt32(Console.ReadLine());
            switch (modify_number)
            {
                case 1:
                    Console.WriteLine("Enter New Employee Id:");
                    int new_Id = Convert.ToInt32(Console.ReadLine());
                    obj_Modify.EmployeeId = new_Id;
                    break;
                case 2:
                    Console.WriteLine("Enter New Employee Name:");
                    string new_Name = Console.ReadLine();
                    obj_Modify.EmployeeName = new_Name;
                    break;
                case 3:
                    Console.WriteLine("Enter New Employee Address:");
                    string new_Address = Console.ReadLine();
                    obj_Modify.Address = new_Address;
                    break;
                case 4:
                    Console.WriteLine("Enter New Employee Salary:");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    obj_Modify.Salary = salary;
                    break;
                default:
                    Console.WriteLine("Invalide Choise....");
                    break;
            }
            




            // employeeList.Add(obj_Modify);
        }

        public void Remove(List<Employee> employeeList, Employee obj_Modify)
        {
            employeeList.Remove(obj_Modify);
            Console.WriteLine("1 Record Removed SuccessFully....!!!");
        }
    }
}
