using System.ComponentModel.DataAnnotations;

namespace MVCAppSGE.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public int idProfesor { get; set; }
        public string? Nombre { get; set; } 
        public string? Clave { get; set; }
    }
}
