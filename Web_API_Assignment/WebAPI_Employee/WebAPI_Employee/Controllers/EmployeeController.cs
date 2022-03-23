using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Employee.Models;

namespace WebAPI_Employee.Controllers
{
    public class EmployeeController : ApiController
    {
        ZensarDBEntities db = new ZensarDBEntities();
        public IHttpActionResult GetSalaryById(int eid)
        {
            var details = db.GetEmpSalary(eid).ToList();
            return Ok(details);
        }
    }
}
