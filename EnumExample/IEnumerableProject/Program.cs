using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableProject
{
   
    class Program
    {
        static void Main(string[] args)
        {
            DetailsList d = new DetailsList();
            Details sam = new Details();
            d.Add(new Details
            {
                Name = "yogi",
                City="Madurai",
                Mailid="postbox"
            });
            d.Add(new Details
            {
                Name = "Ragu",
                City = "Madurai",
                Mailid = "ragumat65"
            });
            d.Add(new Details
            {
                Name = "unknown",
                City = "Madurai",
                Mailid = "unknownmail"
            });
            foreach(Details i in d)
                Console.WriteLine(i.Name+" "+i.City+" "+i.Mailid);
            
            Console.ReadLine();



        }
    }
    class Details
    {
        public Details() { }
        public String Name { get; set; }
        public string City { get; set; }
        public string Mailid { get; set; }

       
    }
    class DetailsList : IEnumerable
    {
        List<Details> list = new List<Details>();
        public void Add(Details d)
        {
            list.Add(d);
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
