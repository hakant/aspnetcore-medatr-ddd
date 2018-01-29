using System.Threading;
using System.Threading.Tasks;

using MediatR;

namespace MarketingDomain.Scenarios
{
    public static class HelloWorld
    {
        public class Request : IRequest<Response>
        {
            public string Name { get; set; }
        }

        public class Response
        {
            public string Message { get; set; }
        }

        public class Handler : IRequestHandler<Request, Response>
        {
            public Handler()
            { }

            public async Task<Response> Handle(Request request, CancellationToken token)
            {
                await Task.Delay(1000);

                return new Response {
                    Message = $"Hello World from {request.Name}!"
                };
            }
        }
    }
}