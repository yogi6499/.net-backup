using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SqlConnection con=new SqlConnection("data source=.;database=Ado.Net_db;integrated security=SSPI"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                //SqlCommand cmd = new SqlCommand("insert into worker(First_Name,Last_Name,Salary,Joining_Date,Department) values ('vicky', 'K', 24000, ' 2021-06-19', 'Software'),('sandeep','R',23000,getDate(),'Software')", con);

                //da.InsertCommand = cmd;
                //da.InsertCommand.ExecuteNonQuery();
               
                da.SelectCommand = new SqlCommand("select * from worker", con);
               
                DataSet ds = new DataSet();
                
                da.Fill(ds);
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {

                        Console.WriteLine(row["Worker_Id"] + " " + row["First_Name"] + " " + row["Last_Name"] + " " + row["Salary"] + " " + row["Joining_Date"] + " " + row["Department"]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
