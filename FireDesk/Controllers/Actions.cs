using FireDesk.Models;
using FireDesk.Repositorios.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace FireDesk.Controllers
{
    public class Actions : Controller
    {
        private readonly ITecnicosRepositorio _tecnicosRepositorio;

        public Actions(ITecnicosRepositorio tecnicosRepositorio)
        {
            _tecnicosRepositorio = tecnicosRepositorio;
        }

        public async Task<IActionResult> Index()
        {
            List<TecnicosModel> tecnicosModels = await _tecnicosRepositorio.GetAll();
            ViewBag.Tecnicos = tecnicosModels.ToList();
            return View();
        }
    }
}