namespace HR_Department.Models.Tables.Interfaces
{
    public interface ITemplateSchedule
    {
        int TemplateScheduleId { get; set; }
        int ScheduleId { get; set; }
        int TemplateId { get; set; }
    }
}
