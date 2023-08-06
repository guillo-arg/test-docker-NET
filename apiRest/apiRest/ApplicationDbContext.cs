using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace apiRest
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }

    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        
    }
}
