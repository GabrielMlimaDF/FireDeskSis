using FireDesk.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FireDesk.DAO;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace FireDesk.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration config)
        {
            _configuration = config;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()

        {
            await using (var connection = new SqlConnection(_configuration.GetConnectionString("FireDesk")))
            {
                const string sql = "SELECT * FROM Tickets WHERE TicketID = 1";
                var tickets = await connection.QueryAsync<TicketsModel>(sql);
                return Ok(tickets);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}