using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string Name { get; set; }

    }

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
