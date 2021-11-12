using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDetails obj1 = new PersonDetails(1, "Yogesh", "Yogi", 22);
            PersonDetails obj2 = new PersonDetails(2, "Vignesh", "Vicky", 22);
            List<PersonDetails> list=new List<PersonDetails>();
            list.Add(obj1);
            list.Add(obj2);
            var result = from details in list
                         select details;
            foreach(var i in result)
                Console.WriteLine($"{i.Id} {i.Fname} {i.Lname} {i.Age}");
            Console.ReadLine();

                       
        }
        
    }
}
