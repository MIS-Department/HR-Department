using System;
using System.ComponentModel.DataAnnotations;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class EmployeeSchedule : IEmployeeSchedule
    {
        public int EmployeeScheduleId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ScheduleId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}
