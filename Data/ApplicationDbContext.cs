using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test_Aiko.DatabaseInitialization;
using Test_Aiko.Models;

namespace Test_Aiko.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // Chama o inicializador do banco de dados
            DbInitializer.Initialize(this);
        }

        public DbSet<Line> Lines { get; set; } = default!;
        public DbSet<Stop> stops { get; set; } = default!;
        public DbSet<Vehicle> vehicles { get; set; } = default!;
        public DbSet<VehiclePosition> vehiclesPositions { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
