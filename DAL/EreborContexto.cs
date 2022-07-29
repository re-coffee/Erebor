using Erebor.Models;
using Microsoft.EntityFrameworkCore;

namespace Erebor.DAL
{
    public class EreborContexto : DbContext
    {
        public EreborContexto() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("EreborContext"));
            }
        }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Servico>? Servicos { get; set; }
        public DbSet<Servidor>? Servidores { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Contrato>? Contratos { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Menu>? Menus { get; set; }
        

    }
}
