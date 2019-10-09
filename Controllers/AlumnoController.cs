using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Proyecto_ASP.NET.Models;

namespace Proyecto_ASP.NET.Controllers
{
    public class AlumnoController: Controller {
        
        public IActionResult Index() {
            var alumno = new Alumno();
            alumno.Nombre = "Pedro Perez";
            alumno.UniqueId = Guid.NewGuid().ToString();

            return View(alumno);
        }

        public IActionResult Listado() {
            var listaAlumnos = new List<Alumno>() {
                new Alumno {
                    Nombre = "Juan Perez",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Ana Gutierrez",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Gonzalo Aguilera",
                    UniqueId = Guid.NewGuid().ToString()
                },
            };

            return View(listaAlumnos);
        }
    }
}