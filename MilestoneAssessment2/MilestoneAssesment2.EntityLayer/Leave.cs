using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneAssesment2.EntityLayer
{
    public class Leave
    {
        public int EmployeeId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int FromSession { get; set; }
        public int ToSession { get; set; }
        public double AppliedLeave { get; set; }
    }
}
