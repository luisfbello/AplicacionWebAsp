using System;
using System.Collections.Generic;

namespace AplicacionWeb.Models
{
    public class Alumno:ObjetoEscuelaBase
    {

        public List<Evaluacion> Evaluaciones { get; set; }
        public Alumno()
        {
            Evaluaciones= new List<Evaluacion>();

        }

        public Alumno(string nombre){

            this.Nombre=nombre;
        }

        

    }
}