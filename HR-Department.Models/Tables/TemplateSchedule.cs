using System.ComponentModel.DataAnnotations;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class TemplateSchedule : ITemplateSchedule
    {
        public int TemplateScheduleId { get; set; }

        [Required]
        public int ScheduleId { get; set; }

        [Required]
        public int TemplateId { get; set; }

    }
}
