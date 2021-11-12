using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class PersonDetails
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public PersonDetails(int id,string fname,string lname,int age)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Age = age;
        }
    }
}
