using System;

namespace HR_Department.Models.Tables.Interfaces
{
    public interface ITemplate
    {
        int TemplateId { get; set; }
        string TemplateCode { get; set; }
        string Description { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
    }
}
