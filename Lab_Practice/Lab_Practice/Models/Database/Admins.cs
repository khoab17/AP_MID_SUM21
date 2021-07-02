using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab_Practice.Models.Database
{
    public class Admins
    {
        SqlConnection conn = new SqlConnection();
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public Admin Get(string UserName, string Password)
        {
            string query = $"select * from Admins Where UserName ='{UserName}' AND Password='{Password}'";
            Admin admin = new Admin();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                admin.Name= reader.GetString(reader.GetOrdinal("Name"));
                admin.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                return admin;
            }
            else
                return null;
        }
    }
}