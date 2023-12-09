using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCAppSGE.Data;
using System;
using System.Linq;

namespace MVCAppSGE.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppSGEContext(
            serviceProvider.GetRequiredService<DbContextOptions<MVCAppSGEContext>>()))
            {
                if (context.Profesor.Any())
                {
                    return;
                }
                context.Profesor.AddRange(
                    new Profesor
                    {
                        Nombre = "Pedro González",
                        Telefono = "4621234567",
                        Escolaridad = "Liceciatura"
                    },
                    new Profesor
                    {
                        Nombre = "Juan Pérez",
                        Telefono = "4629874563",
                        Escolaridad = "Doctorado"
                    },
                    new Profesor
                    {
                        Nombre = "Luis Fernandez",
                        Telefono = "4622587965",
                        Escolaridad = "Maestria"
                    }
                );

                if (context.Alumno.Any())
                {
                    return;
                }
                context.Alumno.AddRange(
                    new Alumno
                    {
                        Matricula = "AM1254",
                        Nombre = "Alejandro Martínez",
                        Grado = "4",
                        Grupo = "A",
                        Email = "correo@email.com",
                        telefono = "462258749"
                    },
                     new Alumno
                     {
                         Matricula = "HDC5874",
                         Nombre = "Hernesto de la Cruz",
                         Grado = "5",
                         Grupo = "A",
                         Email = "uno@dos.com",
                         telefono = "4625896587"
                    },
                     new Alumno
                     {
                         Matricula = "VG25478",
                         Nombre = "Vicente García L´´opez",
                         Grado = "6",
                         Grupo = "B",
                         Email = "vicente@correo.com",
                         telefono = "4624587453"
                    }
                );
                context.SaveChanges();
                }
        }
        
    }
}
