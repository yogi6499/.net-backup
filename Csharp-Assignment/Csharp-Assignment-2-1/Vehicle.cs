using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_2_1
{
    public class Vehicle
    {
        public void Mode()
        {
            Console.WriteLine("Mode of vehicle is RoadWays");
        }
        public void Features()
        {
            Console.WriteLine("It has features like\n\t 1.ABS\n\t2.BlindView\n\t3.HSA\n\t4.HDC");
        }
        public void Noise()
        {
            Console.WriteLine("Roadway Noise");
        }
    }
    public class InheritClass : Vehicle
    {

    }
}
