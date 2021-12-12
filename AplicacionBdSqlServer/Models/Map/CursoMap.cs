using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionBdSqlServer.Models.Map
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Curso");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Alumnos).
                WithMany().
                HasForeignKey(o => o.IdAlumno);

            builder.HasOne(o => o.Profesores).
               WithMany().
               HasForeignKey(o => o.IdProfesor);

        }
    }
}
