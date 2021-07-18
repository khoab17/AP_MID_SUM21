using BusinessEntityLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_4_tier_application.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/Department/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return DepartmentService.GetDepartmentNames();
        }
        [Route("api/Departments")]
        [HttpGet]
        public List<DepartmentModel> GetDepartments()
        {
            return DepartmentService.GetDepartments();
        }
    }
}
