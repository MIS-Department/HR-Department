using System.Data.SqlClient;
using HR_Department.DataLayer;
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
                //var result = connection.GetList<Employee>();

                //var enumerable = result as IList<Employee> ?? result.ToList();
                                                              
                //foreach (var model in enumerable)
                //{
                //    Console.WriteLine("EmployeeId: {0}", model.EmployeeId);
                //    Console.WriteLine("FullName: {0} {1} {2}", model.FirstName, model.MiddleName, model.LastName);
                //    Console.WriteLine("Employee Number: {0}", model.EmployeeNumber);
                //    Console.WriteLine("ImageEmployee {0}", model.ImageEmployee);
                //    Console.WriteLine("===================================");
                //}

                //Assert.AreEqual(1002,enumerable.Count());
            }
        }

        [Test]
        public void EmployeeGetById()
        {
            using (var connection = new SqlConnection(ConfigurationSettings.GetConnectionString()))
            {
                //var result = connection.Get<Employee>(911);
                //Assert.AreEqual(911, result.EmployeeId);
            }
        }
    }
}
