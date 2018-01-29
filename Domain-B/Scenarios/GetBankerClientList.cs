using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

using Data;
using MediatR;

namespace BankingDomain.Scenarios
{
    public static class GetBankerClientList
    {
        public class Request : IRequest<Response>
        {
            public string BankerId { get; set; }
        }

        public class Response
        {
            public IEnumerable<Client> Clients { get; set; }
        }

        public class Handler : IRequestHandler<Request, Response>
        {
            private readonly AppContext _context;

            public Handler(AppContext context)
            {
                _context = context;
            }

            public async Task<Response> Handle(Request request, CancellationToken token)
            {
                var clients = await _context.Clients.Where(c => c.RelatedBankerId == request.BankerId).ToListAsync();


                return new Response
                {
                    Clients = clients
                };
            }
        }
    }
}
