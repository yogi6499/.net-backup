using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Csharp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Get a Number and Display the Number with its Reverse");
            ReverseNum();
            Console.Clear();
            Console.WriteLine("2. Write a C# program to demonstrate the use of the string concatenation operator.");
            ConcatString();
            Console.Clear();
            Console.WriteLine("3. Using “Console” Class Read a Student Marks of 5 Subject and calculate Grade & Display the Grade of student marks.");
            Grade();
            Console.Clear();
            Console.WriteLine("------------Done with Assignment-1------------");
            Console.ReadLine();
        }

        private static void Grade()
        {
            int sum = 0;
            int[] marks = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter mark {i+1}");
                marks[i] = Convert.ToInt32(ReadLine());
            }
            foreach (int mark in marks)
                sum += mark;
            double avg = sum / 5;
            Console.WriteLine("Average marks obtained: "+avg+"\n"+"Your Grade is:");
            if(avg>=90)
                Console.Write("O Grade");
            else if(avg>=80 && avg<90)
                Console.Write("A+ Grade");
            else if(avg>=70 && avg<80)
                Console.Write("A Grade");
            else if(avg>=60 && avg<70)
                Console.Write("B+ Grade");
            else if(avg>=45 && avg<60)
                Console.Write("B Grade");
            else
                Console.Write("RA-(Re-Appear)");
            Console.WriteLine("Press Enter for next question");
            Console.ReadLine();
        }

        private static void ConcatString()
        {
            Console.WriteLine("Enter 1st string");
            string str1 = ReadLine();
            Console.WriteLine("Enter 2nd string");
            string str2 = ReadLine();
            Console.WriteLine($"Concatinated string output: {str1+str2}");
            Console.WriteLine("Press Enter for next question");
            Console.ReadLine();
        }

        private static void ReverseNum()
        {
            Console.Write("Enter number to reverse: ");
            int num = Convert.ToInt32(ReadLine());
            int res=0, pow = 10;
            while (num != 0)
            {
                int rem = num % 10;
                res = res * pow + rem;
                num /= 10;
               
            }
            Console.WriteLine("Reverse number is: "+res);
            Console.WriteLine("Press Enter for next question");
            Console.ReadLine();
        }
    }
}
