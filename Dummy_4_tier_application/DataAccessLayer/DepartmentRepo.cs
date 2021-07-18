using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DepartmentRepo
    {
        static DUMSEntities1 context;
        static DepartmentRepo()
        {
            context = new DUMSEntities1();
        }
        public static List<string> GetDepartmentNames()
        {
            var data=context.Departments.Select(x => x.Name).ToList();
            return data;
        }
        public static List<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }
    }
}
