using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MarketingDomain.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MarketingDomain.Scenarios
{
    public static class GetClientListForCampaign
    {
        public class Request : IRequest<Response>
        { }

        public class Response
        {
            public IEnumerable<Client> Clients { get; set; }
        }

        public class Handler : IRequestHandler<Request, Response>
        {
            private readonly MarketingDbContext _context;

            public Handler(MarketingDbContext context)
            {
                _context = context;
            }

            public async Task<Response> Handle(Request request, CancellationToken token)
            {
                var clients = await _context.Clients.ToListAsync();

                return new Response
                {
                    Clients = clients
                };
            }
        }
    }
}