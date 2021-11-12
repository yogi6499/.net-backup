using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateSales();
            Console.ReadLine();
        }

        private static void CalculateSales()
        {
            using(SqlConnection con=new SqlConnection("data source=.;database=CompanySales;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("YearlySales",con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Console.WriteLine("Enter year to calculate sales");
                int year = Convert.ToInt32(Console.ReadLine());
                cmd.Parameters.AddWithValue("@year",year);
                //SqlParameter outParameter = new SqlParameter
                //{
                //    ParameterName = "@sales", //Parameter name defined in stored procedure
                //    SqlDbType = SqlDbType.Int, //Data Type of Parameter
                //    Direction = ParameterDirection.Output //Specify the parameter as ouput
                //};
                ////add the parameter to the SqlCommand object
                //cmd.Parameters.Add(outParameter);
                con.Open();
                SqlDataReader rdr=cmd.ExecuteReader();
                Console.WriteLine("Enter target of year "+year);
                int target = Convert.ToInt32(Console.ReadLine());
                while (rdr.Read())
                {
                    if (Convert.ToInt32(rdr["sales"]) > target)
                        Console.WriteLine($"sales {rdr["sales"]} {year} is above {target}");
                    else
                        Console.WriteLine($"sales {rdr["sales"]} {year} is below {target}");
                }
            }
        }
    }
}
