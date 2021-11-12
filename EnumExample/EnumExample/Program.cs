using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Action<int, int> a = new Action<int, int>(add);
            a(10, 20);
            IdCompare[] psam = new IdCompare[3]
           {
                new IdCompare("java",4),
                new IdCompare{Name="python",Id=2},
                new IdCompare{Name="c#",Id=1}
           };
            List<IdCompare> l = new List<IdCompare>();
            l.AddRange(psam);
            foreach (IdCompare i in l)
            {
                Console.WriteLine(i.Name+".....");
            }
            l.Sort();
            foreach (IdCompare i in l)
            {
                Console.WriteLine(i.Name);
            }
           //NameCompare psam2 = new NameCompare();
            
            foreach (IdCompare i in l)
            {
                Console.WriteLine(i.Name);
            }
            Console.ReadLine();
        }

        private static void add(int arg1, int arg2)
        {
            Console.WriteLine( arg1+arg2);
        }
    }
    class IdCompare:IComparable<IdCompare>, IComparer<IdCompare>
    {

        public IdCompare()
        {
            Console.WriteLine("pless");
        }
        public IdCompare(string s,int i)
        {
            Name = s;
            Id = i;
            Console.WriteLine("Pc");
        }
        public string Name { get; set; }
        public int Id { get; set; }



        public int Compare(IdCompare x, IdCompare y)
        {
            if ((x.Name.CompareTo(y.Name)) > 1)
                return 1;
            else if (x.Name.CompareTo(y.Name) > 1)
                return -1;
            else
                return 0;
        }

        public int CompareTo(IdCompare other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
    class NameCompare : IComparer<IdCompare>
    {
        public int Compare(IdCompare x, IdCompare y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}





