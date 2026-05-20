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
        public virtual Cita Cita { get; set; } = null!;

        [Required]
        public int ServicioId { get; set; } // ID de la API del maestro

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioAplicado { get; set; }

        public int Cantidad { get; set; } = 1;
    }
}