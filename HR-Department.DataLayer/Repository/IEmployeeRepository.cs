using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Department.Models.Tables;

namespace HR_Department.DataLayer.Repository
{
   public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetEmployeeNumber(string employeeNumber);



    }
}
