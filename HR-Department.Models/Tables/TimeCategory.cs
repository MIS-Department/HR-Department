using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class TimeCategory : ITimeCategory
    {
        public int TimeCategoryId { get; set; }
        public string TimeCategoryValue { get; set; }

    }
}
