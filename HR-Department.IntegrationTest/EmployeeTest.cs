using System.Data.SqlClient;
using System.Linq;
using DapperExtensions;
using HR_Department.DataLayer;
using HR_Department.Models.Tables;
using NUnit.Framework;

namespace HR_Department.IntegrationTest
{
    [TestFixture]
    public class EmployeeTest
    {
        [Test]
        public void EmployeeGetAlltest()
        {
            using (var connection = new SqlConnection(ConfigurationSettings.GetConnectionString()))
            {
                var result = connection.GetList<Employee>();
                Assert.AreEqual(1002,result.Count());
            }
        }
    }
}
