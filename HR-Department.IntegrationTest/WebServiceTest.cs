using System.Linq;
using HR_Department.WebService.Controllers;
using NUnit.Framework;

namespace HR_Department.IntegrationTest
{
    [TestFixture]
    public class WebServiceTest
    {
        [Test]
        public void GetTest()
        {
            var repo = new EmployeeController();

            var result = repo.Get();

            Assert.AreEqual(1002,result.Count());
        }
    }
}
