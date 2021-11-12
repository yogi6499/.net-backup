using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAssignment1.Model;

namespace WebApiAssignment1.Controllers
{
    [Route("api/employee")]
    public class EmployeeController:Controller
    {
       
        [HttpGet]
        public Employee GetEmployee()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Yogi",
                Salary = 26000
            };
            return employee;
        }
    }
}
