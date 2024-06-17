using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubMultidisiplinarioLeones.Models
{
    public class Pago 
    {
        [Key]
        public int ID { get; set; }
        public int NroRecibo { get; set; }
        [Column(TypeName = "date")]
        public DateOnly Fecha { get; set; }
        [Required]
        public int Mes { get; set; }
        [Required]
        public int Anio { get; set; }
        [Required]
        public decimal Total { get; set; }


        // * ----- 1 : Muchos a uno
        public int UsuarioID { get; set; }
        public int ClienteID { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get;set; }

    }
}