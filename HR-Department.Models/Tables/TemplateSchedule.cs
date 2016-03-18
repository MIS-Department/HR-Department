using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class TemplateSchedule
    {
        public int TemplateScheduleId { get; set; }
        public int ScheduleId { get; set; }
        public int TemplateId { get; set; }

    }

    public sealed class TemplateScheduleMapper : ClassMapper<TemplateSchedule>
    {
        public TemplateScheduleMapper()
        {
            Table("TemplateSchedule");
            Map(s => s.TemplateScheduleId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
