using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSyatem.EntityLayer
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(int id, string name, string address, double salary)
        {
            Id = id;
            Name = name;
            Address = address;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { set; get; }
        public double Salary { get; set; }
    }
}
