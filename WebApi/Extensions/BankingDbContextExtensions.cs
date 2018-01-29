using System.Threading.Tasks;

namespace BankingDomain.Data
{
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
