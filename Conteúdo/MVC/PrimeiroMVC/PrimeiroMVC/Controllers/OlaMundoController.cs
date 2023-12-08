using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PrimeiroMVC.Controllers
{
    public class OlaMundoController : Controller
    {
        //public string index()
        public IActionResult Index()
        {
            // As rotas do MVC indicam que este index é chamado automaticamente quando eu acessar a URL/OlaMundo
            return View();
            //return "Olá mundo";
        }

        public string Welcome(int id,  string nome)
        {
            //as rotas do MVC indicam que este index é chamado automaticamente quando eu acessar a URL/OlaMundo/Welcome
            return HtmlEncoder.Default.Encode($"Oi {nome} | id: {id}");
        }

        public IActionResult MostrarMensagem(string nome, int qtd)
        {
            ViewData["Nome"] = nome;
            ViewData["Qtd"] = qtd;

            return View();
        }
    }
}
