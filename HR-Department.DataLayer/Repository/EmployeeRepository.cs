using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HR_Department.Models.Tables;

namespace HR_Department.DataLayer.Repository
{
    public class EmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();


        public Employee GetEmployeeNumber(string employeeNumber)
        {
            using (var connection = new SqlConnection(ConfigurationSettings.GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@EmployeeNumber", employeeNumber);
                return
                    connection.Query<Employee>("EmployeeSelectByEmployeeNumber", p,
                        commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
    }
}
