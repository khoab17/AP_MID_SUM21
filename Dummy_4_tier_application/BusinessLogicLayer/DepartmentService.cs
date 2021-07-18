using BusinessEntityLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DepartmentService
    {
        public static List<string> GetDepartmentNames()
        {
            return DepartmentRepo.GetDepartmentNames();
        }
        public static List<DepartmentModel> GetDepartments()
        {
            var departments= DepartmentRepo.GetDepartments();
            List<DepartmentModel> dp = new List<DepartmentModel>();
            foreach(var item in departments)
            {
                var d = new DepartmentModel()
                {
                    Id = item.Id,
                    Name=item.Name
                };
                dp.Add(d);
            }

            return dp;
        }

    }
}
