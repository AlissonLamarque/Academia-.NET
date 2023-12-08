using Microsoft.AspNetCore.Mvc;
using TestandoASPNETMVC.Models;

namespace TestandoASPNETMVC.Controllers
{
    public class CadastrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar(Cliente c)
        {
            MiniErpContext contexto = new MiniErpContext();
            contexto.Clientes.Add(c);
            contexto.SaveChanges();

            return View(c);
        }

        public IActionResult Consultar()
        {
            MiniErpContext contexto = new MiniErpContext();
            List<Cliente> clientes = (from Cliente c in contexto.Clientes select c).ToList();

            return View(clientes);
        }
    }
}
