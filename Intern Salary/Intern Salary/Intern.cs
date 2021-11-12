using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_Salary
{
   
    public class Intern:IComparable<Intern>
    {
        public Intern() { }
        public int InternId { get; set; }
        public string InternName { get; set; }
        public int PresentDays { get; set; }
        public int AbscentDays { get; set; }
        public long Salary { get; set; }
        public string Month { get; set; }
        public Intern(int id,string name,int abscent,string month)
        {
            InternId = id;
            InternName = name;
            AbscentDays = abscent;
            Month = month;
        }
        public int CompareTo(Intern obj)
        {
            return this.InternName.CompareTo(obj.InternName);
        }

       
    }
}
