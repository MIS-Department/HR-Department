using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{

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
