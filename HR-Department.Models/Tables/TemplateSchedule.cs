using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class TemplateSchedule : ITemplateSchedule
    {
        public int TemplateScheduleId { get; set; }
        public int ScheduleId { get; set; }
        public int TemplateId { get; set; }

    }
}
