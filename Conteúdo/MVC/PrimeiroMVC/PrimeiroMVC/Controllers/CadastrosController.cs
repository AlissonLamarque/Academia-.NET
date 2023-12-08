﻿using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class CadastrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar(Pessoa p)
        {
            BdApiContext contexto = new BdApiContext();
            contexto.Add(p);
            contexto.SaveChanges();

            return View(p);
        }

        public IActionResult Consultar()
        {
            BdApiContext contexto = new BdApiContext();
            List<Pessoa> pessoas = (from Pessoa p in contexto.Pessoas select p).ToList();
            return View(pessoas);
        }
    }
}
