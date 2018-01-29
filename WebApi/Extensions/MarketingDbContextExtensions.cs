using System.Threading.Tasks;

namespace MarketingDomain.Data
{
    /// <summary>
    /// Normally I shouldn't need these extra Seed methods
    /// But somehow InMemoryContext won't let me share data across contexts
    /// </summary>
    public static class MarketingDbContextExtensions
    {
        public static Task Seed(this MarketingDbContext context)
        {
            context.Clients.Add(new Client
            {
                Id = "Client1",
                Name = "James Bond",
                Address = "Dam Square 123, Amsterdam"
            });

            return context.SaveChangesAsync();
        }
    }
}
