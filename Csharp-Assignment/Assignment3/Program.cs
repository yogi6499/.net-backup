using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        public delegate void DelegateMethod(int feet);
        static void Main(string[] args)
        {
            int[] arr = { 5, 66, 3, 98, 62, 55, 79, 91 };
            Console.WriteLine("1. Generate Odd Numbers in LINQ");
            var result = from i in arr
                         where i % 2 != 0
                         select i;
            Console.WriteLine("Odd numbers");
            foreach(var i in result)
                Console.WriteLine(i+" ");
            Console.WriteLine("Press Enter for 2nd question");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("2. Display the Greatest numbers in an Array using WHERE Clause LINQ");
            result = (from i in arr
                      orderby i descending
                      select i).Take(1);
            foreach(var i in result)
            Console.WriteLine("Highest number "+i);
            Console.WriteLine("Press Enter for 3rd question");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("3. Convert Feet to Inches using Delegates");
            int feet = Convert.ToInt32(Console.ReadLine());
            DelegateMethod d1 = new DelegateMethod(FeetToInches);
            d1(feet);
            Console.ReadLine();

        }
        static void FeetToInches(int feet)
        {
            Console.WriteLine($"{feet}Feet is converted to {feet*12}inches");
        }
    }
}
