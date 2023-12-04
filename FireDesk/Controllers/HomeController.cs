using FireDesk.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Dapper;
using FireDesk.Repositorios.Interface;

namespace FireDesk.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITicketsRepositorio _ticketsRepositorio;

        public HomeController(ITicketsRepositorio ticketsRepositorio)
        {
            _ticketsRepositorio = ticketsRepositorio;
        }

        [HttpGet]
        public async Task<IActionResult> GetId(int id)

        {
            TicketsModel ticketsModels = await _ticketsRepositorio.GetId(id);
            return Ok(ticketsModels);

        }

        public async Task<IActionResult> Index()
        {
            List<TicketsModel> ticketsModels = await _ticketsRepositorio.GetAll();
            ViewBag.TicketsAberto = ticketsModels.Where(x => x.Status == "Aberto").Count();
            ViewBag.TicketsAndamento = ticketsModels.Where(x => x.Status == "Em andamento").Count();
            ViewBag.TicketsAtivos = ViewBag.TicketsAberto + ViewBag.TicketsAndamento;
            return View();
        }

    }
}