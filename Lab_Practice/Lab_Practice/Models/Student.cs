using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Practice.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; }

        public int Id { get; set; }
        [Required]
        public string DOB { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]
        public double CGPA { get; set; }
        [Required(ErrorMessage = "Select a Department")]
        public int Dept_id { get; set; }

        public virtual Department Department{ set; get; }
    }
}