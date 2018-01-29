using Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Clients")]
    public class ClientsController : Controller
    {
        private readonly IMediator _mediator;

        public ClientsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Clients/5
        [HttpGet("{bankerId}", Name = "GetBankerClientList")]
        public async Task<IEnumerable<Client>> Get(string bankerId)
        {
            var request = new BankingDomain.Scenarios.GetBankerClientList.Request
            {
                BankerId = bankerId
            };

            var response = await _mediator.Send(request);

            return response.Clients;
        }
    }
}
