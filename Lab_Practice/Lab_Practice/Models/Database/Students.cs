using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab_Practice.Models.Database
{
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Student Get(int id)
        {
            Student student = new Student();
            string query = $"select * from Students Where Id={id} ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                student = new Student()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                };
            }
            conn.Close();
            return student;
        }


        public List<Student> GetALL()
        {
            Student student = new Student();
            string query = $"select * from Students ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                student = new Student()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                };
                students.Add(student);
            }
            conn.Close();
            return students;
        }

        public void Insert(Student student)
        {
            string query = String.Format("Insert into Students values ('{0}','{1}',{2},{3},{4})", student.Name, student.DOB, student.Credit, student.CGPA, student.Dept_id);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(Student student)
        {
            string query = $"Update Students Set Name='{student.Name}', DOB='{student.DOB}' ,Credit={student.Credit}, CGPA={student.CGPA}, Dept_id={student.Dept_id}  Where Id = {student.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int id)
        {
            string query = $"Delete  From Students Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}