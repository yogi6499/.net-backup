using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS3.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNumer { get; set; }
        public string Address { get; set; }
        public int StaffId { get; set; }
    }
}
