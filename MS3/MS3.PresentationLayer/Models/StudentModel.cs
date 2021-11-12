using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS3.PresentationLayer.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNumer { get; set; }
        public string Address { get; set; }
        public int StaffId { get; set; }
    }
}