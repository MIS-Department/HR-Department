using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{
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
