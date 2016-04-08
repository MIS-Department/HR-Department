using HR_Department.Models.Tables.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HR_Department.Models.Tables
{
    public class TimeType : ITimeType
    {    
        public int TimeTypeId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string Name { get; set; }
    }
}
