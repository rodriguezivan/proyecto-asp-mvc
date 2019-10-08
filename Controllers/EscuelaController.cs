using System;
using Microsoft.AspNetCore.Mvc;
using Proyecto_ASP.NET.Models;

namespace Proyecto_ASP.NET.Controllers
{
    public class EscuelaController: Controller {

        public IActionResult Index() {
            var escuela = new Escuela();
            escuela.AñoFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";

            return View(escuela);
        }

    }
}