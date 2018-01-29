using System.Threading.Tasks;

namespace MarketingDomain.Data
{
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
