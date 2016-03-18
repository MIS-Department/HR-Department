using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Http;
using DapperExtensions;
using HR_Department.DataLayer;
using HR_Department.Models.Tables;

namespace HR_Department.WebService.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            using (var connection = new SqlConnection(ConfigurationSettings.GetConnectionString()))
            {
                return connection.GetList<Employee>();
            }
        }

        // GET: api/Employee/5
        public Employee Get(int id)
        {
            using (var connection = new SqlConnection(ConfigurationSettings.GetConnectionString()))
            {
                return connection.Get<Employee>(id);
            }
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
