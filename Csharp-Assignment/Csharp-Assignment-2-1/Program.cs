using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_2_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Display Cost of a Rectangle Plot Using Inheritance");
            RectanglePlotCost obj = new RectanglePlotCost();          
            obj.CalculateCost();
            Console.WriteLine("Press enter for second Question");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("2. Create a class inheri() procedure that inherit the vehicle class. Create the variable ‘obj’ as an object for inheri() procedure . Using the ‘obj’ object variable we are calling the mode(), feature(), Noise() function.");
            Console.WriteLine();
            InheritClass obj1 = new InheritClass();
            obj1.Mode();
            obj1.Features();
            obj1.Noise();
            Console.WriteLine("Press enter for third Question");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Perform Calculator");
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
           
            A: string op = Console.ReadLine();
            if (op == "+" || op == "-" || op == "*" || op == "/")
            {
                Console.WriteLine("Enter Num2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Calculator(num1, num2, op);
            }
            else
            {
                try
                {
                    throw new ValidOperatorException("Enter Valid Operator sign");
                    
                }
                catch(ValidOperatorException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto A;
                }
            }
            Console.ReadLine();
        }

        public static void Calculator(int num1, int num2, string op)
        {
            int result;
            switch (op)
            {
                
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"{num1}+{num2}={result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1}-{num2}={result}");
                    break;
                case "*":
                    result = num2 * num1;
                    Console.WriteLine($"{num1}*{num2}={result}");
                    break;
                case "/":
                    try
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1}/{num2}={result}");
                    }
                    catch(DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        
                    }
                    break;
            }
        }
    }

    [Serializable]
    internal class ValidOperatorException : Exception
    {
        public ValidOperatorException()
        {
        }

        public ValidOperatorException(string message) : base(message)
        {
        }

        public ValidOperatorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidOperatorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
