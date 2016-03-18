using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class TimeCategory
    {
        public int TimeCategoryId { get; set; }
        public string TimeCategoryValue { get; set; }

    }

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
