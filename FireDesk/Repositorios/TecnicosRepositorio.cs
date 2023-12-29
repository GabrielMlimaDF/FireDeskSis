using Dapper;
using FireDesk.Models;
using FireDesk.Repositorios.Interface;
using System.Data.SqlClient;

namespace FireDesk.Repositorios
{
    public class TecnicosRepositorio : ITecnicosRepositorio
    {
        private readonly IConfiguration _configuration;

        public TecnicosRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<TecnicosModel> Create(TecnicosModel model)
        {
            throw new NotImplementedException();
        }

        public Task<TecnicosModel> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TecnicosModel>> GetAll()
        {
            await using (var connection = new SqlConnection(_configuration.GetConnectionString("FireDesk")))
            {
                const string sql = "SELECT * FROM Tecnicos";
                var tecnicos = await connection.QueryAsync<TecnicosModel>(sql);
                return (List<TecnicosModel>)tecnicos;
            }
        }

        public Task<TecnicosModel> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TecnicosModel> Update(TecnicosModel model, int id)
        {
            throw new NotImplementedException();
        }
    }
}