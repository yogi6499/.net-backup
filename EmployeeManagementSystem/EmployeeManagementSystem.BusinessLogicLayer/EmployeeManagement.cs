using EmployeeManagementSyatem.EntityLayer;
using EmployeeManagementSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.BusinessLogicLayer
{
    public class EmployeeManagement
    {
        DatabaseManagement db = new DatabaseManagement();
        public int AddEmployee(Employee employee,List<Employee> list)
        {
            list.Add(employee);
            return db.AddEmployee(employee);
            
        }
        public void display()
        {
            db.Display();
        }

        public void Search(int id)
        {
            db.Search(id);
        }

        public int edit(int id,int choice)
        {
            return db.edit(id,choice);
        }

        public int delete(int id)
        {
            return db.delete(id);
        }
    }
}
