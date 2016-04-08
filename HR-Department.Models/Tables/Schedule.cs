using System.ComponentModel.DataAnnotations;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class Schedule : ISchedule
    {
        public int ScheduleId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Schedule Name must be longer than 3 characters")]
        public string Name { get; set; }

    }
}
