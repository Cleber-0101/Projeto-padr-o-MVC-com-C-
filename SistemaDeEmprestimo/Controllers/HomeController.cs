using Microsoft.AspNetCore.Mvc;
using SistemaDeEmprestimo.Models;
using System.Diagnostics;

namespace SistemaDeEmprestimo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //pagina especifica 
            //abre a pagina 
            return View();
        }

        public IActionResult Privacy()
        {
            //pagina especifica
            //abre a pagina 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
