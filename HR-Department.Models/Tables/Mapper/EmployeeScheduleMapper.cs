using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{

    public sealed class EmployeScheduleMapper : ClassMapper<EmployeeSchedule>
    {
        public EmployeScheduleMapper()
        {
            Table("EmployeeSchedule");
            Map(s => s.EmployeeScheduleId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
