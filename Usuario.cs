using ClubMultidisiplinarioLeones.Dto;
using System.ComponentModel.DataAnnotations;

namespace ClubMultidisiplinarioLeones.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required, MinLength(5)]
        public string? Nombre { get; set; }

        [Required, MinLength(5)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required, MinLength(5)]
        public string? Password { get; set; }

        public RolEnum Rol { get; set; }


        // 1 ----- * : Un usuario reagistra muchos pagos 

        public virtual List<Pago>? Pagos { get; set; }
    }
}
