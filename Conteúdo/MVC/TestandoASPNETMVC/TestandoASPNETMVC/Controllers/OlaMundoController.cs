using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TestandoASPNETMVC.Controllers
{
    public class OlaMundoController : Controller
    {
        // As rotas do MVC indicam que este index é chamado automaticamente quando eu acessar a URL/OlaMundo
        public IActionResult Index()
        {
            return View();
        }
        // As rotas do MVC indicam que este index é chamado automaticamente quando eu acessar a URL/OlaMundo/Welcome
        public string Welcome(string nome, int id)
        {
            return HtmlEncoder.Default.Encode("oi " + nome + " ID: " + id);
            //return "Estou no método welcome";
        }

        public IActionResult MostrarMensagem(string nome, int qtd)
        {
            ViewData["Nome"] = nome;
            ViewData["Qtd"] = qtd;
            return View();
        }
    }
}
