//Create a ADO object in a project. Use relevant name spaces for the inclusion of the object. Open a database connection with the DB Server. (SQL Server / Oracle / MySql)

//Create a table in the server with the following schema.
//Worker
//Worker_Id First_Name Last_Name Salary Joining_Date Department

//Insert appropriate values in the table. Write query to Fetch unique values of DEPARTMENT from Worker table and another query to Print the first three characters of FIRST_NAME from Worker table.

//Use appropriate DBCommand Object and Display the results.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADO.NET_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTable();
            InsertValues();
            ValuesOfDepartment();
            Console.ReadLine();
        }

        private static void ValuesOfDepartment()
        {
            Console.WriteLine("enter department to fetch");
            String dept = Console.ReadLine();
            using(SqlConnection con=new SqlConnection("data source=.;database=Ado.Net_db;integrated security=SSPI"))
            {
                SqlCommand com = new SqlCommand($"select * from Worker where Department='{dept}'", con);
                SqlCommand com2 = new SqlCommand($"select left(First_Name,3) [Extract Name] from Worker where Department='{dept}'", con);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["Worker_Id"]+" "+dr["First_Name"]);

                }
                dr.Close();
                Console.WriteLine("Extracting first 3 characters from First Name");
                dr = com2.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["Extract Name"]);

                }
                Console.ReadLine();
            }
        }

        private static void InsertValues()
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=Ado.Net_db;integrated security=SSPI"))
            {
                SqlCommand com = new SqlCommand("insert into Worker values('Yogeshwaran','R',26000,getDate(),'Software')", con);
                con.Open();
                com.ExecuteNonQuery();
            }
        }
        private static void CreateTable()
        {
            using (SqlConnection con=new SqlConnection("data source=.f;database=Ado.Net_db;integrated security=SSPI"))
            {
                SqlCommand com = new SqlCommand("create table Worker(Worker_Id int primary key identity(1, 1),First_Name nvarchar(20),    Last_Name nvarchar(20),    Salary money,    Joining_Date date,    Department nvarchar(20)); ", con);
                con.Open();
                com.ExecuteNonQuery();
            }
        }
    }
}
