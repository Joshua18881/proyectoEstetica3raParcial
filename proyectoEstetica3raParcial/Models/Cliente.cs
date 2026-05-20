using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace proyectoEstetica3raParcial.Models
{
    public class Cliente
    {
        [Key] 
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? Telefono { get; set; } // El '?' significa que puede ser nulo

        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; } = string.Empty;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        // Relación: Un cliente puede tener muchas citas
        public List<Cita> Citas { get; set; } = new List<Cita>();
    }
}
