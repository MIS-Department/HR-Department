using System.ComponentModel.DataAnnotations;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class TimeCategory : ITimeCategory
    {
        public int TimeCategoryId { get; set; }

        [Required]
        public string TimeCategoryValue { get; set; }

    }
}
