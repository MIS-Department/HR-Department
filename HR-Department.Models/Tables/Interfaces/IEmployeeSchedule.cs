using System;

namespace HR_Department.Models.Tables.Interfaces
{
    public interface IEmployeeSchedule
    {
        int EmployeeScheduleId { get; set; }
        int EmployeeId { get; set; }
        int ScheduleId { get; set; }
        DateTime Date { get; set; }
    }
}
