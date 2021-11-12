using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace FileIOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"F:\new.txt";
            WriteFile(filename);
            ReadFile(filename);
            
            Console.Read();
        }
        static void WriteFile(String filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                if (fs.CanWrite)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("Hello Yogi!..You successfully understood fileIO concept");
                    fs.Write(buffer, 0, buffer.Length);
                }
            }
           
        }
        static void ReadFile(String filenmae)
        {
            

            using (FileStream fs = new FileStream(filenmae, FileMode.Open, FileAccess.Read))
            {
                if (fs.CanRead)
                {
                    byte[] buffer = new byte[1024];
                    int byteread = fs.Read(buffer, 0, buffer.Length);
                    string[] arr=Encoding.ASCII.GetString(buffer, 0, byteread).Split(' ');
                    for(int i=0;i<arr.Length;i++)
                    Console.WriteLine(arr[i]);
                    List<string> l = new List<string>(arr);
                    foreach(string word in l)
                        Console.Write(word+" ");
                }
            }
        }
    }
}
