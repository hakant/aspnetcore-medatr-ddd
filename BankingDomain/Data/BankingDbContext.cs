using Microsoft.EntityFrameworkCore;

namespace BankingDomain.Data
{
    public class BankingDbContext: DbContext
    {
        public BankingDbContext(DbContextOptions<BankingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Banker> Bankers { get; set; }

        public DbSet<Client> Clients { get; set; }
    }
}
