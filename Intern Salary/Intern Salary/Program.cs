using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ganss.Excel;


namespace Intern_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 100;
            Console.WriteLine("Enter number of inters");
            int numberOfInters = Convert.ToInt32(ReadLine());
            Intern[] interns = new Intern[numberOfInters];
            InternFile file = new InternFile();
            InternRepository iRes = new InternRepository();
            for(int i = 0; i < numberOfInters; i++)
            {
                Console.WriteLine("Intern Name");
                string name = ReadLine();
                Console.WriteLine("Intern Absent days");
                int aDays= Convert.ToInt32(ReadLine());
                A: Console.WriteLine("Intern salary month");
                string month,msg;
                month = ReadLine(); 
                
                interns[i] = new Intern(id,name,aDays,month);
                id++;
                try
                {
                   msg= iRes.GetNewIntern(interns[i]);
                }
                
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto A;
                }
                Console.WriteLine(msg);
                
            }
            List<Intern> sortedList = iRes.SortInternByName();
            Console.WriteLine("InternId    InternName    AbsentDays    PresentDays    Salary    Month");
            foreach (Intern details in sortedList)
            {
            Console.WriteLine("{0}         {1}           {2}           {3}            {4}       {5}",details.InternId,details.InternName,details.AbscentDays,details.PresentDays,details.Salary,details.Month);
            }

            Console.WriteLine(file.Serialize(sortedList)); 
            List<Intern> retriveList=file.DeSerialize(sortedList);
            Console.WriteLine("Retrived list");
            Console.WriteLine("InternId    InternName    AbsentDays    PresentDays    Salary    Month");
            foreach (Intern details in retriveList)
            {
                Console.WriteLine("{0}         {1}           {2}           {3}            {4}       {5}", details.InternId, details.InternName, details.AbscentDays, details.PresentDays, details.Salary, details.Month);
            }
            ExcelMapper mapper = new ExcelMapper();
            var newfile = @"F:\interndetails2.xlsx";
            mapper.Save(newfile, sortedList, "sheetname", true);
            
            Console.ReadLine();
        }
    }
}
