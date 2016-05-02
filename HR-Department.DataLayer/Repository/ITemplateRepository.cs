using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Department.Models.Tables;

namespace HR_Department.DataLayer.Repository
{
    public interface ITemplateRepository
    {
        Task<IEnumerable<Template>> SelectAll();
        Task<Template> SelectById(int? id);
        Task<int> Insert(Template model);
        //Task Delete(int? id);
        //Task Update(Template model);
        //Task<IEnumerable<Template>> SelectByName(string name);
    }
}
