using System;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class Template : ITemplate
    {
        public int TemplateId { get; set; }
        public string TemplateCode { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
