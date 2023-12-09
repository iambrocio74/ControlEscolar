using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCAppSGE.Models
{
    public class ProfesorNombreViewModel
    {
        //public List<Profesor> Profesores { get; set; }
        //public SelectList? Nombre { get; set; }
        public string? ProfesorNombre { get; set; }
        public string? SearchString { get; set; }
    }
}
