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
            asignatura1.Id="2";
            asignatura1.Nombre="Matematicas";
             var asignatura2=new Asignatura();
            asignatura2.Id="3";
            asignatura2.Nombre="Español";
             var asignatura3=new Asignatura();
            asignatura3.Id="4";
            asignatura3.Nombre="Biologia";



            listAsignatura.Add(asignatura1);
            listAsignatura.Add(asignatura2);
            listAsignatura.Add(asignatura3);

            

            
            return View(listAsignatura);
        }
    }
}