using System.Threading.Tasks;

namespace BankingDomain.Data
{
    /// <summary>
    /// Normally I shouldn't need these extra Seed methods
    /// But somehow InMemoryContext won't let me share data across contexts
    /// </summary>
    public static class BankingDbContextExtensions
    {
        public static Task Seed(this BankingDbContext context)
        {
            context.Bankers.Add(new Banker
            {
                Id = "Banker1",
                Name = "Hakan Tuncer"

            });

            context.Clients.Add(new Client
            {
                Id = "Client1",
                RelatedBankerId = "Banker1",
                Name = "James Bond",
                NetWorth = 27340677
            });

            return context.SaveChangesAsync();
        }
    }
}
