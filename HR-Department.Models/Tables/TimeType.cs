using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class TimeType : ITimeType
    {
        
        public int TimeTypeId { get; set; }
        public string Name { get; set; }
    }
}
