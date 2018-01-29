using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

namespace DomainA.Scenarios.HelloWorld
{
    public static class GetHelloWorld
    {
        public class Request : IRequest<GetHelloWorld.Response>
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