using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ClubMultidisiplinarioLeones.Models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }

        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El Nombre es requerido.")]

        public int  CI { get; set; }
        [Required,MinLength(7),MaxLength(8)]

        public DateOnly FechaNacimiento { get; set; }
        [Required]

        public int NroCelular { get; set; }
        [Required, MaxLength(8)]

        public decimal MontoDeRegistro { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        // 1 ---- * : Un cliente realiza muchos pagos
        [NotMapped]
        public string? Info { get { return $"{Nombre},{CI}"; } }
        public virtual List<Pago>? Pagos { get; set; }


        // * ---- 1 : Muchos clientes Tienen un Personal
        public  int IDPersonal { get; set; }
        public virtual Personal? Personal { get; set; }


        // 1 --- * : Un cliente Puede tener Varios Horarios
        public virtual List<Horario>? Horarios { get; set; }
    }
}
