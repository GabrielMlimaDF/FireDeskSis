using Microsoft.AspNetCore.Mvc;

namespace FireDesk.Controllers
{
    public class Actions : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
