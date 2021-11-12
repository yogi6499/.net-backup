using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SchoolManagementSystem.EntityLayer;
using System.Data;
using System.Collections;

namespace StudentManagementSystem.DatabaseLayer
{
    public class DbClass
    {
        public int AddTeacher(Teacher teacher)
        {
            using(SqlConnection con=new SqlConnection("data source=.;database=SchoolManagementSystem;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand($"insert into teacher values ('{teacher.Name}','{teacher.Subject}','{teacher.Gender}',{teacher.Salary})", con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public List<Student> SearchStudent(int id, Student student)
        {
            List<Student> list = new List<Student>();
            using (SqlConnection con = new SqlConnection("data source=.;database=SchoolManagementSystem;integrated security=SSPI"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.SelectCommand = new SqlCommand($"select * from student where studentId={id}", con);
                DataSet ds = new DataSet();
                da.Fill(ds,"student");
                foreach(DataRow rows in ds.Tables["student"].Rows)
                {
                    
                    list.Add(new Student
                    {
                        Id = Convert.ToInt32(rows["studentId"]),
                        Name=Convert.ToString(rows["name"]),
                        Age=Convert.ToInt32(rows["age"]),
                        Gender=Convert.ToString(rows["gender"])
                    }) ;
                }
            }
            return list;
        }

        public List<string> NumberOfStudents(int id)
        {
            List<string> list = new List<string>();
            using (SqlConnection con = new SqlConnection("data source=.;database=SchoolManagementSystem;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand($"select t.name [teacherName],count(s.name) [count]from teacher t inner join student s on s.teacherId=t.teacherId where t.teacherId={id} group by t.name", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read()){
                    string teacherName = Convert.ToString(dr["teacherName"] + " teaches " + dr["count"] + " students");
                    list.Add(teacherName);
                }
            }
            return list;
        }

        public List<Teacher> SearchTeacher(int id, Teacher teacher)
        {
            List<Teacher> list = new List<Teacher>();
            using (SqlConnection con = new SqlConnection("data source=.;database=SchoolManagementSystem;integrated security=SSPI"))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                con.Open();
                da.SelectCommand = new SqlCommand($"select * from teacher where teacherId={id}", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "teacher");
                foreach (DataRow rows in ds.Tables["teacher"].Rows)
                {

                    list.Add(new Teacher
                    {
                        Id = Convert.ToInt32(rows["teacherId"]),
                        Name = Convert.ToString(rows["name"]),
                        Salary = Convert.ToDouble(rows["salary"]),
                        Gender = Convert.ToString(rows["gender"]),
                        Subject=Convert.ToString(rows["subject"])
                    });
                }
            }
            return list;
        }

        public int AddStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection("data source=.;database=SchoolManagementSystem;integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand($"insert into student(name,age,gender,teacherId) values ('{student.Name}',{student.Age},'{student.Gender}',{student.TeacherId})", con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
