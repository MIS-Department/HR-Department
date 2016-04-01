using System;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class EmployeeSchedule : IEmployeeSchedule
    {
        public int EmployeeScheduleId { get; set; }
        public int EmployeeId { get; set; }
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }

    }
}
