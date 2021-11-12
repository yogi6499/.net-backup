using MilestoneAssesment2.CustomExceptionLayer;
using MilestoneAssesment2.DatabaseLayer;
using MilestoneAssesment2.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneAssesment2.BuisnessLogicLayer
{
    public class BuisnessLogic
    {
        DataBaseManagement dataBaseManagement = new DataBaseManagement();
        public bool AddEmployee(Employee employee)
        {
            int rowsAffected = dataBaseManagement.AddEmployee(employee);
            if (rowsAffected > 0)
                return true;
            else
                return false;
        }

        public bool ApplyLeave(Leave leave)
        {
            try
            {
                int rowsAffected = dataBaseManagement.ApplyLeave(leave);
                if (rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch(DuplicateEmailIDException ex) 
            {
                throw ex;
            }
            
        }

        public List<string> GetLeave(int id)
        {
            return dataBaseManagement.GetLeave(id);
        }

        public bool DeleteLeave(int id)
        {
            int value=dataBaseManagement.DeleteLeave(id);
            if (value > 0)
                return true;
            else
                return false;
        }

        public bool DeleteEmployee(int id)
        {
            int value = dataBaseManagement.DeleteEmployee(id);
            if (value > 0)
                return true;
            else
                return false;
        }
    }
}
