using System;
using System.Collections.Generic;

namespace AplicacionWeb.Models
{
    public class Escuela : ObjetoEscuelaBase
    {
        public int AnioCreacion { get; set; }
        public string Pais { get; set; }
        public string ciudad { get; set; }

        public TipoEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }
        public string Direccion { get; set; }


    }
}