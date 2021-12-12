using AplicacionBdSqlServer.Models.Map;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionBdSqlServer.Models
{
    public interface IClasesUpnContext
    {
         DbSet<Alumno> Alumnos { get; set; }
         DbSet<Profesor> Profesors { get; set; }
         DbSet<Curso> Cursos { get; set; }
        List<Curso> ListaCursos { get; set; }
    }
    public class ClasesUpnContext : DbContext, IClasesUpnContext
    {

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        public  List<Curso> ListaCursos { get; set; }
        public ClasesUpnContext(DbContextOptions<ClasesUpnContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AlumnoMap());
            modelBuilder.ApplyConfiguration(new ProfesorMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
        }
    }
}
