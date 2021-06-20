using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_Practice.Models.ViewModel
{
    public class StudentDepartment
    {
        public Student student { set; get; }

        public List<Department> departments { set; get; }

        
        public StudentDepartment()
        {
            departments = new List<Department>();
        }
    }
}