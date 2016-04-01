using System;     

namespace HR_Department.Models.Tables.Interfaces
{
    public interface ICalculatedTime
    {        
        int CalculatedTimeId { get; set; }
        int TimeTypeId { get; set; }
        DateTime Value { get; set; }
        int DateTimeRecordId { get; set; }
    }
}
