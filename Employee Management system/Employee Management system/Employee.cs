using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_system
{
    public class Employee : IComparable<Employee>
    {
        public Employee() { }
        public Employee(int id, string name, string address, double salary)
        {
            EmployeeId = id;
            EmployeeName = name;
            Address = address;
            Salary = salary;
        }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }



        public int CompareTo(Employee obj)
        {
            if (this.Salary > obj.Salary)
                return 1;
            else if (this.Salary < obj.Salary)
                return -1;
            else
                return 0;
            
        }
    }
}
