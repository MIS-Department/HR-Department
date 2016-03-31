using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{


    public sealed class ScheduleMapper : ClassMapper<Schedule>
    {
        public ScheduleMapper()
        {
            Table("Schedule");
            Map(s => s.ScheduleId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
