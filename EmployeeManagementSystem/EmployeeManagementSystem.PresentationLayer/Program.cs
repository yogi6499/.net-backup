using EmployeeManagementSyatem.EntityLayer;
using EmployeeManagementSystem.BusinessLogicLayer;
using EmployeeManagementSystem.ExceptionHandlingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 1, choice ;
            Employee employee = new Employee();
            EmployeeManagement employeeManagement = new EmployeeManagement();
            List<Employee> list = new List<Employee>();
            while (exit == 1)
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine(@"****Welcome To Employee Management System****
                                    1)  Add a new employee id, name, salary, address
                                    2)	List all Employee with name, Id 
                                    3)	Search Employee with ID
                                    4)	Edit Employee by ID
                                    5)	Delete Employee by ID
                                    6)  Exit
                                    ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Employee ID: ");
                        int Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name: ");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Address: ");
                        string Address = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary: ");
                        double Salary = Convert.ToDouble(Console.ReadLine());
                        employee = new Employee(Id, Name, Address, Salary);
                        int rowsAffected= employeeManagement.AddEmployee(employee,list);
                        Console.WriteLine(rowsAffected+" rows affected");
                        break;
                    case 2:
                        
                        Console.WriteLine("Database details");
                        employeeManagement.display();
                        break;
                    case 3:
                        Console.WriteLine("Enter Id to search");
                        int id = Convert.ToInt32(Console.ReadLine());                       
                        Console.WriteLine("In Database");
                        employeeManagement.Search(id);
                        break;
                    case 4:
                        Console.WriteLine("Enter id to edit");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter which column to edit");
                        Console.WriteLine("1.ID\n2.Name\n3.Address\n4.Salary");
                        int ch=Convert.ToInt32(Console.ReadLine());
                        rowsAffected = employeeManagement.edit(id,ch);
                        if(rowsAffected>0)
                        Console.WriteLine(rowsAffected + " rows affected");
                        else
                        {
                            try
                            {
                                throw new IdErrorException("Enter valid id");
                            }
                            catch(IdErrorException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter id to edit");
                        id = Convert.ToInt32(Console.ReadLine());
                        rowsAffected = employeeManagement.delete(id);
                        Console.WriteLine(rowsAffected + " rows affected");
                        break;
                    case 6:
                        exit = 0;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
