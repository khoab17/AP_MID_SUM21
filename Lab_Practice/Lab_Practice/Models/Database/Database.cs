﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Lab_Practice.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        public Departments Departments { get; set; }
        public Database()
        {
            string connString = @"Server=.;Database=UMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);
            Departments = new Departments(conn);

        }
    }
}