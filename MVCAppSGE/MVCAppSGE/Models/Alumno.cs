using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MVCAppSGE.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required]
        public string? Matricula { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        [RegularExpression(@"^[1-9]*$")]
        public string? Grado { get; set; }

        public string? Grupo { get; set; }
        public string? Email { get; set; }

        [RegularExpression(@"^[1-9]+[0-9]*$")]
        public string? telefono { get; set; }
    }
}
