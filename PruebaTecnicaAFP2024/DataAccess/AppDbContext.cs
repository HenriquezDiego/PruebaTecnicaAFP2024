using Microsoft.EntityFrameworkCore;
using PruebaTecnicaAFP2024.Models;

namespace PruebaTecnicaAFP2024.DataAccess
{
    public class AppDbContext  : DbContext
    {
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Color>().Property(c => c.Nombre).HasMaxLength(50);
            modelBuilder.Entity<Color>().HasData(DataSeeder.Colores);
            modelBuilder.Entity<Marca>().Property(c => c.Nombre).HasMaxLength(50);
            modelBuilder.Entity<Marca>().HasData(DataSeeder.Marcas);
            modelBuilder.Entity<Vehiculo>()
                .Property(c => c.Vin)
                .HasMaxLength(25);
            modelBuilder.Entity<Vehiculo>()
                .Property(c => c.NumeroPlaca)
                .HasMaxLength(16);
            modelBuilder.Entity<Vehiculo>().HasData(DataSeeder.Vehiculos);

        }
    }
}
