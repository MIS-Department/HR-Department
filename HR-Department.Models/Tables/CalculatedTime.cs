using System;
using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class CalculatedTime
    {
        public int CalculatedTimeId { get; set; }
        public int TimeTypeId { get; set; }
        public DateTime Value { get; set; }
        public int DateTimeRecordId { get; set; }

    }

    public sealed class CalculatedTimeMapper : ClassMapper<CalculatedTime>
    {
        public CalculatedTimeMapper()
        {
            Table("CalculatedTime");
            Map(s => s.CalculatedTimeId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
