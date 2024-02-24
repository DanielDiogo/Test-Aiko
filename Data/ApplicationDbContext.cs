using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Test_Aiko.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly IServiceProvider _serviceProvider;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.Parent?.FullName;

            if (!string.IsNullOrEmpty(parentDirectory))
            {
                // Combinar o caminho do diretório pai com a pasta "Banco"
                string dataDirectory = Path.Combine(parentDirectory, "Banco");

                // Definir o diretório de dados
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
