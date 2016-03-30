using DapperExtensions.Mapper;

namespace HR_Department.Models.Tables.Mapper
{


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
