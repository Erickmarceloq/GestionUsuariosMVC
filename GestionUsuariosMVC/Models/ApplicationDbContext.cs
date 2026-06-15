using Microsoft.EntityFrameworkCore;

namespace GestionUsuariosMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Conexión directa a LocalDB de tu Visual Studio
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DB_Usuarios_Roles;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}