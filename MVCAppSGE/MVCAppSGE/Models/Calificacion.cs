using System.ComponentModel.DataAnnotations;

namespace MVCAppSGE.Models
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public int IdMateria { get; set; }
        public float calif { get; set; }
        public string? TipoEvaluacion { get; set; }

    }
}
