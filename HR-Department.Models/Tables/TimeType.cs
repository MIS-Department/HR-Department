using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class TimeType
    {
        public int TimeTypeId { get; set; }
        public string Name { get; set; }
    }

    public sealed class TimeTypeMapper : ClassMapper<TimeType>
    {
        public TimeTypeMapper()
        {
            Table("TimeType");
            Map(s => s.TimeTypeId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
