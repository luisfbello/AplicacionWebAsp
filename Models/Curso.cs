using System;
using System.Collections.Generic;


namespace AplicacionWeb.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Tipojornada { get; set; }

        public List<Asignatura> Asignaturas { get; set; }

        public List<Alumno> Alumnos { get; set; }
        public string Direccion { get; set ; }

    }
}