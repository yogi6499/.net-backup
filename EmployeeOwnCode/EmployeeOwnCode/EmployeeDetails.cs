using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOwnCode
{
    public class EmployeeDetails:IEnumerable<EmployeeDetails>
    {
        public EmployeeDetails() { }
        public EmployeeDetails(int id, string name, string address, double salary)
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

        public IEnumerator<EmployeeDetails> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
