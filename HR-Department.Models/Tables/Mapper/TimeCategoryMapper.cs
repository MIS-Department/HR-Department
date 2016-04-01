using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{   
    public sealed class TimeCategoryMapper : ClassMapper<TimeCategory>
    {
        public TimeCategoryMapper()
        {
            Table("TimeCategory");
            Map(s => s.TimeCategoryId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
