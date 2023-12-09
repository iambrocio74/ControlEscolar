using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAppSGE.Models;

namespace MVCAppSGE.Data
{
    public class MVCAppSGEContext : DbContext
    {
        public MVCAppSGEContext (DbContextOptions<MVCAppSGEContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAppSGE.Models.Profesor> Profesor { get; set; } = default!;
        public DbSet<MVCAppSGE.Models.Materia> Materia { get; set; } = default!;
        public DbSet<MVCAppSGE.Models.Alumno> Alumno { get; set; } = default!;
        public DbSet<MVCAppSGE.Models.Calificacion> Calificacion { get; set; } = default!;
    }
}
