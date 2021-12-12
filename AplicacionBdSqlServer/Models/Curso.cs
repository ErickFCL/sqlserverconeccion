using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionBdSqlServer.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public decimal Nota { get; set; }
        public int Credito { get; set; }

        //Relaciones
        public Alumno Alumnos { get; set; }
        public Profesor Profesores { get; set; }
    }
}
