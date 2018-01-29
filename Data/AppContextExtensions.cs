using System.Threading.Tasks;

namespace Data
{
    public static class AppContextExtensions
    {
        public static Task Seed(this AppContext context)
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
                Address = "Dam Square 123, Amsterdam",
                NetWorth = 27340677
            });

            return context.SaveChangesAsync();
        }
    }
}
