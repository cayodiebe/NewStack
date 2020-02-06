using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KoniaInter.Models;

namespace KoniaInter.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Calculo()
        {
            Calculo calculo = new Calculo();

            calculo.valor2 = 10;
            calculo.valor1 = 10;
            calculo.operacao = "+";
            ViewData["Total"] = calculo.CalculaValores(calculo);
            return View();
        }

        //##Será Necessário Criar uma nova IAccountResult para a Home de Calculo##


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
;