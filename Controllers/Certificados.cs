﻿using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class Certificados : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    public IActionResult Criar()
    {
        return View();
    }
    public IActionResult Editar()
    {
        return View();
    }
    public IActionResult Apagar()
        {
         return View();
        }
    }
}



