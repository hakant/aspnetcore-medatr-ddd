using Microsoft.EntityFrameworkCore;

namespace MarketingDomain.Data
{
    public class MarketingDbContext: DbContext
    {
        public MarketingDbContext(DbContextOptions<MarketingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
