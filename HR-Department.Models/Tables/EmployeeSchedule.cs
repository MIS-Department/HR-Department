using System;
using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class EmployeeSchedule
    {
        public int EmployeeScheduleId { get; set; }
        public int EmployeeId { get; set; }
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }
    }

    public sealed class EmployeeScheduleMapper : ClassMapper<EmployeeSchedule>
    {
        public EmployeeScheduleMapper()
        {
            Table("EmployeeSchedule");
            Map(s => s.EmployeeId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
