using System;
using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables
{
    public class Template
    {
        public int TemplateId { get; set; }
        public string TemplateCode { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }

    public sealed class TemplateMapper : ClassMapper<Template>
    {
        public TemplateMapper()
        {
            Table("Template");
            Map(s => s.TemplateId).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
