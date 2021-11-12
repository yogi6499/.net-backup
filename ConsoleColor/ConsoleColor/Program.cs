using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ConsoleColo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{500000:c}");
            var colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            (int foreground, int background) userInput;
            do
            {
                userInput = DisplayColor(colors);
                if (userInput.background == colors.Length + 1)
                {
                    WriteLine("Default color");
                    ResetColor();
                    WriteLine("Press any key");
                    ReadLine();
                    Clear();
                    userInput=DisplayColor(colors);
                }
                else if (userInput.background==colors.Length+ 2||userInput.foreground == colors.Length + 2)
                {

                }
                else
                {
                    BackgroundColor = colors[userInput.background];
                    ForegroundColor = colors[userInput.foreground];
                    WriteLine("Background color " +BackgroundColor);
                    WriteLine("Foreground color " + ForegroundColor);
                }
            } while (userInput.background != colors.Length + 2||userInput.foreground!=colors.Length+2);

        }
        private static (int,int) DisplayColor(ConsoleColor[] colors)
        {
            int count = 0;
            foreach(var color in colors)
            {
                WriteLine($"{count} {color}");
                count++;
            }
            WriteLine($"{count + 1} Reset");
            WriteLine($"{count + 2} Exit");
            Write("Enter Background Color: " );
            int background = ToInt32(ReadLine());
            Write("Enter foreground color: ");
            int foreground = ToInt32(ReadLine());
            return new ValueTuple<int,int>(background, foreground);
        }
    }
}
