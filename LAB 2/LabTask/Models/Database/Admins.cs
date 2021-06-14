using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask.Models.Database
{
    public class Admins
    {
        SqlConnection conn;

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Admin Get(string UserName)
        {
            Admin admin = new Admin();
            string query = $"select * from Admins Where UserName='{UserName}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                admin = new Admin()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    UserName = reader.GetString(reader.GetOrdinal("UserName")),
                    Password = reader.GetString(reader.GetOrdinal("Password")),    
                };
            }
            conn.Close();
            return admin;
        }

    }
}