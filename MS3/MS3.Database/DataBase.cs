using MS3.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS3.Database
{
    public class DataBase
    {
        
        public void AddStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=KinderGarden;integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AddStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@dob", student.DOB);
                cmd.Parameters.AddWithValue("@number", student.ContactNumer);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                //cmd.Parameters.AddWithValue("@staffId", student.StaffId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Staff> DisplayStaff()
        {
            List<Staff> list = new List<Staff>();
            using (SqlConnection con = new SqlConnection("data source=.;database=KinderGarden;integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from staff", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Staff staff = new Staff()
                    {
                        StaffId = Convert.ToInt32(sdr[0]),
                        StaffName = Convert.ToString(sdr[1]),
                        ContactNumber = Convert.ToString(sdr[2]),
                        EmailId = Convert.ToString(sdr[3]),
                        ClassType = Convert.ToString(sdr[4])
                        //StaffId = Convert.ToInt32(sdr[5])


                    };
                    list.Add(staff);
                }
            }
            return list;
        }

        public Student DisplayById(int id)
        {
            Student student=new Student();
            using (SqlConnection con = new SqlConnection("data source=.;database=KinderGarden;integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"select * from student where id={id}", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                   student= new Student()
                    {
                        Id = Convert.ToInt32(sdr[0]),
                        Name = Convert.ToString(sdr[1]),
                        DOB = Convert.ToDateTime(sdr[2]),
                        ContactNumer = Convert.ToString(sdr[3]),
                        Address = Convert.ToString(sdr[4]),
                        //StaffId = Convert.ToInt32(sdr[5])


                    };
                }
                return student;
            }
            
        }

        public void AssignStaff(Student student)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=KinderGarden;integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"update student set staffId={student.StaffId} where id={student.Id}", con);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Student> DisplayStudent()
        {
            List<Student> list = new List<Student>();
            using (SqlConnection con = new SqlConnection("data source=.;database=KinderGarden;integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from student", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Student student = new Student()
                    {
                        Id = Convert.ToInt32(sdr[0]),
                        Name = Convert.ToString(sdr[1]),
                        DOB = Convert.ToDateTime(sdr[2]),
                        ContactNumer = Convert.ToString(sdr[3]),
                        Address = Convert.ToString(sdr[4]),
                        //StaffId = Convert.ToInt32(sdr[5])


                    };
                    list.Add(student);
                }
            }
            return list;
        }
        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=KinderGarden;integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("deleteStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update(int id,string number,string mailId)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=KinderGarden;integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("updateStaffDetails", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@number", number);
                cmd.Parameters.AddWithValue("@emailId", mailId);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Student> StudentBasedOnStaff(int staffId)
        {
            List<Student> list = new List<Student>();
            using (SqlConnection con = new SqlConnection("data source=.;database=KinderGarden;integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("staffSelectedStudentList", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", staffId);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Student student = new Student()
                    {
                        Id=Convert.ToInt32(sdr[0]),
                        Name=Convert.ToString(sdr[1]),
                        DOB=Convert.ToDateTime(sdr[2]),
                       ContactNumer=Convert.ToString(sdr[3]),
                        Address=Convert.ToString(sdr[4]),
                        //StaffId=Convert.ToInt32(sdr[5])


                    };
                    list.Add(student);
                }
            }
            return list;
        }
        
    }
}
