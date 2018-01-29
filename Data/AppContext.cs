using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public DbSet<Banker> Bankers { get; set; }

        public DbSet<Client> Clients { get; set; }
    }
}
