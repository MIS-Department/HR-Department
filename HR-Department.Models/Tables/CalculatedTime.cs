using System;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class CalculatedTime : ICalculatedTime
    {
        public int CalculatedTimeId { get; set; }
        public int TimeTypeId { get; set; }
        public DateTime Value { get; set; }
        public int DateTimeRecordId { get; set; }

    }   
}
