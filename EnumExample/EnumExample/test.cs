using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class test
    {
        static void Main(string[] args) {
            P2[] p = new P2[5]
            {
                p[0]=new P2(Name="yogi",Id=1),
                p[1]=new P2(Name="yogesh",Id=2)
            };
            List<P2> l = new List<P2>;
            foreach(var i in l)
                Console.WriteLine(i.Id+":"+i.Name);
        }
    }
    class P2
    {

        public P2()
        {

        }
        public string Name { get; set; }
        public int Id { get; set; }



        public int CompareTo(object obj)
        {
            return Id.CompareTo(obj);
        }


    }
}
