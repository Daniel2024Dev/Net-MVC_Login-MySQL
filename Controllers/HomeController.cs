using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ex_data_base_com_seção.Models;

namespace Ex_data_base_com_seção.Controllers
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
            //INSTANCIA DA FUNÇÃO TesteConexao DE AlunosRepository
            AlunosRepository ar = new AlunosRepository();
            ar.TesteConexao();
            //INSERINDO VALORES EM Alunos
            Alunos a = new Alunos();
            a.Nome = "Daniel";
            a.Usuario = "Daniel";
            a.Senha = "12345";
            a.DataNasc = DateTime.Now;
            
            //RECEBENDO VALORES DE Alunos PELO PARÂMETRO a ENVIANDO PARA A FUNÇÃO Inserir
            ar.Inserir(a);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
