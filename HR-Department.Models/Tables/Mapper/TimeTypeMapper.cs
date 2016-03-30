using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{    
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
