using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAssignment2.Model
{
    public class TimeEntry
    {
        

        public long? Id { get; set; }

        public long ProjectId { get; set; }

        public long UserId { get; set; }

        public string Date { get; set; }

        public int Hours { get; set; }
        
    }
}
