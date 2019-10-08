using System;
using Microsoft.AspNetCore.Mvc;
using Proyecto_ASP.NET.Models;

namespace Proyecto_ASP.NET.Controllers
{
    public class AsignaturaController: Controller {
        
        public IActionResult Index() {                    
            var asignatura = new Asignatura {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };
                        
            ViewBag.CantidadAlumnos = new Random().Next(10, 50);

            return View(asignatura);
        }

    }
}