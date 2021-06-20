using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Practice.Models
{
    public class Department
    {
        [Required]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}