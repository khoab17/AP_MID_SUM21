using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask.Models.Database
{
    public class Departments
    {
        SqlConnection conn;

        public Departments(SqlConnection conn)
        {
            this.conn = conn;
        }


        public Department Get(int id)
        {
            
            Department department = new Department();
            string query = $"select * from Departments Where Id={id} ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                department = new Department()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                };
            }
            conn.Close();
            return department;
        }


        public List<Department> GetALL()
        {
            Department department = new Department();
            string query = $"select * from Departments ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Department> departments = new List<Department>();
            while (reader.Read())
            {
                department = new Department()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    
                };
                departments.Add(department);
            }
            conn.Close();
            return departments;
        }

        public void Insert(Department department)
        {
            string query = String.Format("Insert into Departments values ('{0}')", department.Name);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }


    }
}