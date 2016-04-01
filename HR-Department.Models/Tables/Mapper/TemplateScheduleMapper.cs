using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{    
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
