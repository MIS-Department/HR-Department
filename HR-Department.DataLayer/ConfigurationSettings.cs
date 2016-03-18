using System.Configuration;

namespace HR_Department.DataLayer
{
    public static class ConfigurationSettings
    {
        private static string _connectionString;

        public static string GetConnectionString()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
            return _connectionString;
        }
    }
}
