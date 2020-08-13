using AplicacionWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var esculela=new Escuela();
            esculela.Id="1";
            esculela.Nombre="Laureano Gomez";
            esculela.AnioCreacion=1985;
            esculela.Pais="Colombia";
            esculela.ciudad="Bogota";
            esculela.Direccion="Cll 89 # 95f-17";
            esculela.TipoEscuela=TipoEscuela.Secundaria;


            return View(esculela);
        }

    }
}