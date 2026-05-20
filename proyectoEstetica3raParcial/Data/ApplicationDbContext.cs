using Microsoft.EntityFrameworkCore;
using proyectoEstetica3raParcial.Models;

namespace proyectoEstetica3raParcial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<DetalleServicio> DetallesServicios { get; set; }
    }
}