using System;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class DailyTimeRecord : IDailyTimeRecord
    {
        public int DailyTimeRecordId { get; set; }
        public int EmployeeId { get; set; }
        public int TimeCategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime Time { get; set; }

    }
}
