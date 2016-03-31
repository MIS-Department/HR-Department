using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class Schedule : ISchedule
    {
        public int ScheduleId { get; set; }
        public string Name { get; set; }

    }
}
