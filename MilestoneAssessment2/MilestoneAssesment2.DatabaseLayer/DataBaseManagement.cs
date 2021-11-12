using MilestoneAssesment2.CustomExceptionLayer;
using MilestoneAssesment2.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneAssesment2.DatabaseLayer
{
    public class DataBaseManagement
    {
        public int AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=HumanResourceManagement;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand($"insert into employee(name,address,EmailId,joiningDate,contactNumber) values ('{employee.Name}','{employee.Address}','{employee.EmailId}','{employee.JoiningDate}','{employee.ContactNumber}')", con);
                con.Open();
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    throw new DuplicateEmailIDException("Mailid already exists");
                }
            }
        }

        public int ApplyLeave(Leave leave)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=HumanResourceManagement;integrated security=SSPI"))
            {
                
                SqlCommand cmd = new SqlCommand("AppliedDays", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", leave.EmployeeId);
                cmd.Parameters.AddWithValue("@fromDate", leave.FromDate);
                cmd.Parameters.AddWithValue("@toDate", leave.ToDate);
                cmd.Parameters.AddWithValue("@fromSession", leave.FromSession);
                cmd.Parameters.AddWithValue("@toSession", leave.ToSession);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=HumanResourceManagement;integrated security=SSPI"))
            {

                SqlCommand cmd = new SqlCommand($"delete from employee where id={id}", con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteLeave(int id)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=HumanResourceManagement;integrated security=SSPI"))
            {

                SqlCommand cmd = new SqlCommand($"delete from leave where leaveId={id}", con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetLeave(int id)
        {
            List<string> list = new List<string>();
            using (SqlConnection con = new SqlConnection("data source=.;database=HumanResourceManagement;integrated security=SSPI"))
            {
                
                SqlCommand cmd = new SqlCommand("select  l.leaveid [leaveId],l.fromDate [fromDate],l.toDate [toDate],l.fromSession [fromSession],l.toSession [toSession],e.name [name] from leave l inner join employee e on e.id = l.EmployeeId where e.id = 1 ", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string data = Convert.ToString("LeaveId: "+rdr["leaveId"] + "From Date:" + rdr["fromDate"] + " ToDate: "+rdr["toDate"]+" FromSession "+rdr["fromSession"]+" ToSession "+rdr["toSession"]+" Employee Name "+rdr["name"]);
                    list.Add(data);
                }
            }
            return list;
        }
    }

   
}
