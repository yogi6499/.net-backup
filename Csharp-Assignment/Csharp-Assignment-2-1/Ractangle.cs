using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_2_1
{
    class Rectangle
    {
        public int Length { get; set; }
        public int Bredth { get; set; }
        public double Rate { get; set; }
    }
    class RectanglePlotCost:Rectangle
    {
        public void CalculateCost()
        {
            Console.WriteLine("Enter Length of Rectangle: ");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bredth of Rectangle: ");
            Bredth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Cost of rectangle plot per 100metres: ");
            Rate = Convert.ToDouble(Console.ReadLine());
            long area= CalculateArea(Length, Bredth);
            double cost = (Rate / 100) * area;
            Console.WriteLine($"Cost of rectangle plot: {cost}");
        }
        static long CalculateArea(int len, int bre) => len * bre;
    }
}
