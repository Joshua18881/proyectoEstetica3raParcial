using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoEstetica3raParcial.Models
{
    public class Cita
    {
        [Key]
        public int CitaId { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; } = null!;

        [Required]
        public DateTime FechaHora { get; set; }

        [MaxLength(50)]
        public string Estado { get; set; } = "Pendiente";

        [MaxLength(500)]
        public string? Notas { get; set; }

        public virtual ICollection<DetalleServicio> Detalles { get; set; } = new List<DetalleServicio>();
    }
}