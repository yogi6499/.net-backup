﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWebapi.Data
{
    public class Employee
    {
     
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string MailId { get; set; }
        public DateTime DOJ { get; set; }
    }
}
