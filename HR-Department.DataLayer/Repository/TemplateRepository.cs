using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HR_Department.Models.Tables;
using OG_MFTG.DataLayer.Util;

namespace HR_Department.DataLayer.Repository
{
    public class TemplateRepository : ITemplateRepository
    {
        private IDbConnection _connection;

        public async Task<IEnumerable<Template>> SelectAll()
        {
            try
            {
                _connection = Connect.Open();
                return
                    await
                        _connection.QueryAsync<Template>("TemplateSelectAll", commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _connection.Dispose();
            }
        }

        public async Task<Template> SelectById(int? id)
        {
            try
            {
                _connection = Connect.Open();
                var p = new DynamicParameters();

                p.Add("@TemplateId", id);

                var result =
                    await
                        _connection.QueryAsync<Template>("TemplateSelectByID", p,
                            commandType: CommandType.StoredProcedure);

                return result.FirstOrDefault();
            }

            catch (Exception)
            {

                throw;
            }
            finally
            {
                _connection.Dispose();
            }
        }

        public async Task<int> Insert(Template model)
        {
            try
            {
                _connection = Connect.Open();
                var p = new DynamicParameters();
                p.Add("@TemplateId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@TemplateCode", model.TemplateCode);
                p.Add("@Description", model.Description);
                p.Add("@Start", model.StartTime);
                p.Add("@End", model.EndTime);
                await _connection.ExecuteAsync("TemplateInsert", p, commandType: CommandType.StoredProcedure);

                return p.Get<int>("@TemplateId");

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
