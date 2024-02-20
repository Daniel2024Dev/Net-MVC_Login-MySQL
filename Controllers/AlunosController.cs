using Microsoft.AspNetCore.Mvc;
using Ex_data_base_com_seção.Models;
//PACOTE DA FUNÇÃO SEÇÃO DE USUÁRIO
using Microsoft.AspNetCore.Http;
namespace Ex_data_base_com_seção.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        // Controller >> Views >> Controller >> Model
        [HttpPost] //RECEBENDO VALORES DE Cadastrar EM Views
        public IActionResult Cadastrar(Alunos a)
        {
            //CRIANDO OBJETO DA CLASSE AlunosRepository
            AlunosRepository ar = new AlunosRepository();
            //INSTANCIANDO A FUNÇÃO Inserir DE Model
            ar.Inserir(a); //PASSANDO OS OBJETOS DE Cadastrar EM Views PARA A FUNÇÃO Inserir EM Model POR PARÂMETRO
            return View();
        }

        //ESSA PAGINA APARECE SÓ QUANDO O USUÁRIO ESTIVER LOGADO
        public IActionResult Listar()
        {
            // SE O USUÁRIO NÃO ESTIVER LOGADO SERÁ REDIRECIONADO PARA Login EM Views
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
            {
                return RedirectToAction("Login");
            }
            AlunosRepository ar = new AlunosRepository();
            return View(ar.Listar());//PASSANDO A LISTA DE Listar EM Model POR PARÂMETRO PARA Listar EM Views
        }
        public IActionResult Editar(int Id)
        {
            AlunosRepository ar = new AlunosRepository();
            return View(ar.BuscaPorId(Id));
        }
        [HttpPost]
        public IActionResult Editar(Alunos a)
        {
            AlunosRepository ar = new AlunosRepository();
            ar.Editar(a);
            return RedirectToAction("Listar");
        }

        public IActionResult Excluir(int Id)//Usando O "/Alunos/Excluir?Id=@a.IdAlunos" DE Listar EM Views
        {
            AlunosRepository ar = new AlunosRepository();
            ar.Deletar(Id);
            return RedirectToAction("Listar");//APÓS A FUNÇÃO SER EXECUTADA SERA REDIRECIONADA PARA Listar EM Views
        }
        public IActionResult Login()
        {
            return View();
        }
        //VALIDANDO SEÇÃO
        [HttpPost]
        public IActionResult Login(Alunos a)
        {
            AlunosRepository ar = new AlunosRepository();
            Alunos usuario = ar.ValidarLogin(a); //usuario RECEBE Alunos POR PARÂMETRO
            if(usuario == null) //VERIFICANDO SE O USUÁRIO É NULO
            {
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("IdUsuario",usuario.IdAluno); //SEÇÃO É UM REGISTRO DE ACESSO
                HttpContext.Session.SetString("usuario",usuario.Usuario); //SEÇÃO É UM REGISTRO DE ACESSO

                //int IdUsuario = (int)HttpContext.Session.GetInt32("IdAluno"); //CAPTURA DE ID DO USUARIO LOGADO PARA INSERÇÃO NO BANCO DE DADOS

                return RedirectToAction("Listar");//SE O USUÁRIO E SENHA ESTIVER CORRETO SERÁ REDIRECIONADO PARA A PAGINA LISTAR
            }
            
        }
    }
}