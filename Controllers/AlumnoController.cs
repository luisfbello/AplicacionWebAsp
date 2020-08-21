using System;
using System.Collections.Generic;
using System.Linq;
using AplicacionWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            string[] nombre = { "Luis", "Eliana", "Andres", "Felipe", "Francisco", "Elva" };
            string[] apellido = { "Bello", "Gonzalez", "Garnica", "Montenegro", "Vargas", "Velazquez" };

            // usando linq 

            var listAlumnos = from n1 in nombre
                              from ap in apellido
                              select new Alumno { Id=Guid.NewGuid().ToString() ,Nombre = $"{n1} {ap}" };


             
            

            
            return View(listAlumnos.OrderBy((al) => al.Id).ToList());
        }
    }
}