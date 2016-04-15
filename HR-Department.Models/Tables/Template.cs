using System;
using System.ComponentModel.DataAnnotations;
using HR_Department.Models.Tables.Interfaces;

namespace HR_Department.Models.Tables
{
    public class Template : ITemplate
    {
        public int TemplateId { get; set; }

        [Required]
        public string TemplateCode { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(80, MinimumLength = 10)]
        public string Description { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public DateTime EndTime { get; set; }

    }
}
