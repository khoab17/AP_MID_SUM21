using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask.Models.Database
{
    public class Database
    {
        public Admins Admins { get; set; }
        public Departments Departments { get; set; }
        public Students Students { get; set; }
        //public Categories Categories { get; set; }
        public Database()
        {
            string connString = @"Server=.;Database=UMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            //Admins = new Admins(conn);
            //Categories = new Categories(conn);
            Admins = new Admins(conn);
            Students = new Students(conn);
            Departments = new Departments(conn);
        }
    }
}