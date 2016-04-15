using System;
using System.ComponentModel.DataAnnotations;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class DailyTimeRecord : IDailyTimeRecord
    {
        public int DailyTimeRecordId { get; set; }

        [Required]
<<<<<<< HEAD
        public int EmployeeId { get; set; }

        [Required]
        public int TimeCategoryId { get; set; }
=======
        public int? EmployeeId { get; set; }

        [Required]
        public int? TimeCategoryId { get; set; }
>>>>>>> master

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }

    }
}
