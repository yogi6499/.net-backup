using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EmployeeManagementSyatem.EntityLayer;
using System.Data;

namespace EmployeeManagementSystem.DatabaseLayer
{
    public class DatabaseManagement
    {
        public int AddEmployee(Employee employee)
        {
            using (SqlConnection con=new SqlConnection("data source=.;database=EmployeeManagementSystem;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand($"insert into employee(id,name,salary,empAddress) values ({employee.Id},'{employee.Name}',{employee.Salary},'{employee.Address}')",con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int edit(int id,int choice)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=EmployeeManagementSystem;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand();
                switch (choice) {
                    case 1:
                        Console.WriteLine("Enter new Id");
                        cmd = new SqlCommand($"update employee set id={Convert.ToInt32(Console.ReadLine())} where id={id}",con);
                        break;
                    case 2:
                        Console.WriteLine("Enter new Name");
                        cmd = new SqlCommand($"update employee set name='{Console.ReadLine()}' where id={id}",con);
                        break;
                    case 3:
                        Console.WriteLine("Enter new Address");
                        cmd = new SqlCommand($"update employee set empAddress='{Console.ReadLine()}' where id={id}",con);
                        break;
                    case 4:
                        Console.WriteLine("Enter new Salary");
                        cmd = new SqlCommand($"update employee set salary={Convert.ToDouble(Console.ReadLine())} where id={id}",con);
                        break;
                   

                }
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int delete(int id)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=EmployeeManagementSystem;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand($"delete from employee where id={id}", con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public void Search(int id)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=EmployeeManagementSystem;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand($"select id [ID],name [Name] from employee where id={id}", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                    Console.WriteLine(sdr["id"] + "  " + sdr["name"]);
            }
        }

        public void Display()
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=EmployeeManagementSystem;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("select id [ID],name [Name] from employee", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"]+"  "+sdr["name"]+" "+sdr["salary"]);
                }
               
            }
        }
    }
}
