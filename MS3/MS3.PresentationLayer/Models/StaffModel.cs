using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS3.PresentationLayer.Models
{
    public class StaffModel
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string ClassType { get; set; }
    }
}