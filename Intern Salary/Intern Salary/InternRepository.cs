using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern_Salary
{
    public class InternRepository
    {
        List<Intern> internList = new List<Intern>();
        public String GetNewIntern(Intern intern)
        {
            intern.PresentDays = PresentDays(intern);
            intern.Salary = CalculateSalary(intern.PresentDays);
            internList.Add(intern);
            return "New Intern Added Successfully";
        }
        public List<Intern> SortInternByName()
        {
            internList.Sort();
            return internList;
        }
        private long CalculateSalary(int presentDays)
        {
            
            return presentDays * 500;
        }

        private int PresentDays(Intern intern)
        {
            string month = intern.Month;
            int presentDays=0;
            switch (month)
            {
                case "January":case "March":case "May": case "July": case "August":case "October":case "December":
                    presentDays = 31 - intern.AbscentDays;
                    break;
                case "April": case "June": case "September": case "Novenber":
                    presentDays = 30 - intern.AbscentDays;
                    break;
                case "Febraury":
                    presentDays = 28 - intern.AbscentDays;
                    break;
                default:
                    throw new Exception("Enter valid month with 1st letter as capttal");
                    
                    break;
                
            }
            return presentDays;
        }
    }
}
