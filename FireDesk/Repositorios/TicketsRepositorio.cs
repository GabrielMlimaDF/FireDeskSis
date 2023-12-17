using Dapper;
using FireDesk.Models;
using FireDesk.Repositorios.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Data;
using System.Data.SqlClient;
namespace FireDesk.Repositorios
{
    public class TicketsRepositorio : ITicketsRepositorio
    {
        private readonly IConfiguration _configuration;

        public TicketsRepositorio(IConfiguration config)
        {
            _configuration = config;
        }

        public Task<TicketsModel> CreateTickets(TicketsModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TicketsModel>> GetAll()
        {
           
                await using (var connection = new SqlConnection(_configuration.GetConnectionString("FireDesk")))
                {
                    const string sql = "SELECT * FROM Ticket";
                    var tickets = await connection.QueryAsync<TicketsModel>(sql);
                    return (List<TicketsModel>)tickets;
                }
           
           
        }

        public async Task<TicketsModel> GetId(int id)
        {
            
            await using (var connection = new SqlConnection(_configuration.GetConnectionString("FireDesk")))
            {
                const string sql = "SELECT * FROM Ticket WHERE TicketId = @TicketID";
                var tickets = await connection.QueryFirstAsync<TicketsModel>(sql, new { TicketId = id });
                return tickets;
            }
        }

        public Task<TicketsModel> UpdateTickets(TicketsModel model, int id)
        {
            throw new NotImplementedException();
        }

        public Task<TicketsModel> DeleteTickets(int id)
        {
            throw new NotImplementedException();
        }
    }
}