using System.Data.SqlClient;
using System.Linq;
using Dapper.Extensions.Linq.Extensions;
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

        [Test]
        public void EmployeeGetById()
        {
            using (var connection = new SqlConnection(ConfigurationSettings.GetConnectionString()))
            {
                var result = connection.Get<Employee>(911);
                Assert.AreEqual(911, result.EmployeeId);
            }
        }
    }
}
