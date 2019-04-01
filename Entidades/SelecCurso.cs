﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    ///clase de seleccion de cursos en linea con la de estudiante
    /// </summary>
   public class SelecCurso
    {
        public int Id { set; get; }
        public int Estudiante { set; get; }
        public string Dia { set; get; }
        public string Hora { set; get; }
        public string Cede { set; get; }

        public SelecCurso(int id, int estudiante, string dia, string hora, string cede)
        {
            Id = id;
            Estudiante = estudiante;
            Dia = dia;
            Hora = hora;
            Cede = cede;
        }
    }
}
