using System;
using Microsoft.AspNetCore.Mvc;
using Proyecto_ASP.NET.Models;

namespace Proyecto_ASP.NET.Controllers
{
    public class EscuelaController: Controller {

        public IActionResult Index() {
            var escuela = new Escuela();

            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Dirección = "Avd. Principal, 220";
            escuela.Ciudad = "Ciudad de Córdoba";
            escuela.Pais = "Argentina";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            return View(escuela);
        }

    }
}