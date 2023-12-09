using System.ComponentModel.DataAnnotations;

namespace MVCAppSGE.Models
{
    public class Profesor
    {
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set;}

        [RegularExpression(@"^[1-9]+[0-9]*$")]
        [StringLength(10)]
        public string? Telefono { get; set; }
        public string? Escolaridad { get; set; }
    }
}
