using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoEstetica3raParcial.Models
{
    public class DetalleServicio
    {
        [Key]
        public int DetalleId { get; set; }

        [Required]
        public int CitaId { get; set; }

        [ForeignKey("CitaId")]
        public virtual Cita? Cita { get; set; }

        // Esta es la propiedad que causaba error, aquí la unificamos:
        [Required]
        public int ProductoApiId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal Precio { get; set; }
    }
}