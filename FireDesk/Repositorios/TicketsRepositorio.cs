﻿using Dapper;
using FireDesk.Models;
using FireDesk.Repositorios.Interface;
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


        public async Task<List<TicketsModel>> GetAll()
        {
            await using (var connection = new SqlConnection(_configuration.GetConnectionString("FireDesk")))
            {
                const string sql = "SELECT * FROM Tickets";
                var tickets = await connection.QueryAsync<TicketsModel>(sql);
                return (List<TicketsModel>)tickets;
            }
        }
    }
}