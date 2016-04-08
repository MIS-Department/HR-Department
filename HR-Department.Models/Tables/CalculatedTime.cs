using System;
using System.ComponentModel.DataAnnotations;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class CalculatedTime : ICalculatedTime
    {
        public int CalculatedTimeId { get; set; }

        [Required]
        public int TimeTypeId { get; set; }

        [Display(Name = "Manpower Hours")]
        [Required]
        public DateTime Value { get; set; }

        [Required]
        public int DateTimeRecordId { get; set; }

    }   
}
