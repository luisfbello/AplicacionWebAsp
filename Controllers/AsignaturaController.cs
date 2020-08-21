using System;
using System.Collections.Generic;
using AplicacionWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            List<Asignatura> listAsignatura=new List<Asignatura>();
            
            var asignatura1=new Asignatura();
            asignatura1.Id=Guid.NewGuid().ToString();
            asignatura1.Nombre="Matematicas";
             var asignatura2=new Asignatura();
            asignatura2.Id=Guid.NewGuid().ToString();;
            asignatura2.Nombre="Español";
             var asignatura3=new Asignatura();
            asignatura3.Id=Guid.NewGuid().ToString();;
            asignatura3.Nombre="Biologia";



            listAsignatura.Add(asignatura1);
            listAsignatura.Add(asignatura2);
            listAsignatura.Add(asignatura3);

            

            
            return View(listAsignatura);
        }
    }
}