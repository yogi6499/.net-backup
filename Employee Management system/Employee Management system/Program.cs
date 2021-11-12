using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;



namespace Employee_Management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 1;
            EmployeeManagement obj_Company = new EmployeeManagement();
            EmployeeFile fileObject = new EmployeeFile(); 
            List<Employee> employeeList = new List<Employee>();
            
            int search_Id;
            do
            {
                Console.Clear();
                Console.WriteLine("**************************EMPLOYEE MANAGEMENT SYSTEM MENU******************************");
                Console.WriteLine("1. Add  an Employee");
                Console.WriteLine("2. View Employee details");
                Console.WriteLine("3. Search Employee details");
                Console.WriteLine("4. Modify Employee details");
                Console.WriteLine("5. Remove Employee details");
                Console.WriteLine("6. Exit");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.Write("Enter Your Choise Here:-");
                int choose_number = Convert.ToInt32(Console.ReadLine());

                switch (choose_number)
                {
                    case 1:
                        obj_Company.AddEmployee(employeeList);
                       
                        break;
                    case 2:
                        obj_Company.DisplayEmployee(employeeList);
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee Id Which You Want To Search:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Employee obj_search = obj_Company.Search(employeeList, search_Id);
                        if (obj_search != null)
                        {
                            Console.WriteLine("Employee ID \t{0}", obj_search.EmployeeId);
                            Console.WriteLine("Employee Name \t{0}", obj_search.EmployeeName);
                            Console.WriteLine("Employee Address \t{0}", obj_search.Address);
                            Console.WriteLine("Salary \t{0}\n", obj_search.Salary);
                            Console.WriteLine("Press Enter");
                            Console.ReadLine();
                        }
                        else
                        {
                            try
                            {
                                throw new RecordNotFoundException("Enter valid id");
                            }
                            catch(RecordNotFoundException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter Employee Id Which You Want To Edit:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Employee obj_Modify = obj_Company.Search(employeeList, search_Id);
                        if (obj_Modify != null)
                        {
                            Console.WriteLine("Employee ID      :" + obj_Modify.EmployeeId);
                            Console.WriteLine("Employee Name    :" + obj_Modify.EmployeeName);
                            Console.WriteLine("Employee Address :" + obj_Modify.Address);
                            Console.WriteLine("salary      :" + obj_Modify.Salary);
                            obj_Company.ModifyEmployee(employeeList, obj_Modify);
                            
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter Employee Id Which You Want To delete:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Employee obj_Delete = obj_Company.Search(employeeList, search_Id);
                        if (obj_Delete != null)
                        {
                            Console.WriteLine("Employee ID      :" + obj_Delete.EmployeeId);
                            Console.WriteLine("Employee Name    :" + obj_Delete.EmployeeName);
                            Console.WriteLine("Employee Address :" + obj_Delete.Address);
                            Console.WriteLine("Designation      :" + obj_Delete.Salary);
                            obj_Company.Remove(employeeList, obj_Delete);
                            Console.WriteLine("Removed from list");
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }
                        break;
                    case 6:
                        exit = 0;
                        sortedList(employeeList);                     
                        fileObject.Serialize(employeeList);                       
                        List<Employee> deserializedList=fileObject.DeSerialize(employeeList);
                        Console.WriteLine("Deserialized details");
                        foreach(Employee i in deserializedList)
                        {
                            Console.WriteLine($"{i.EmployeeId} {i.EmployeeName} {i.Address} {i.Salary}");
                        }
                        Console.WriteLine("Number of employees "+deserializedList.Count);
                        Console.WriteLine("Exiting..");
                        break;
                    default:
                        Console.WriteLine("Invalide Choise... Please Enter Correct Choice...");
                        break;
                }
                
            } while (exit==1);
            
            Console.ReadLine();
        }
        public static void sortedList(List<Employee> employeeList)
        {
            List<Employee> sortedList = employeeList;
            sortedList.Sort();
            foreach (Employee i in sortedList)
                Console.WriteLine($"{i.EmployeeId} {i.EmployeeName} {i.Address} {i.Salary}");
            Console.WriteLine("Sorted done using IComparator");
        }

       


    }

    [Serializable]
    internal class RecordNotFoundException : Exception
    {
        public RecordNotFoundException()
        {
        }

        public RecordNotFoundException(string message) : base(message)
        {
        }

        public RecordNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RecordNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}