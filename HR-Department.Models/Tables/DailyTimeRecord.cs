using System;
using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class DailyTimeRecord
    {
        public int DailyTimeRecordId { get; set; }
        public int EmployeeId { get; set; }
        public int TimeCategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime Time { get; set; }

    }

    public sealed class DailyTimeRecordMapper : ClassMapper<DailyTimeRecord>
    {
        public DailyTimeRecordMapper()
        {
            Table("DailyTimeRecord");
            Map(s => s.DailyTimeRecordId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
