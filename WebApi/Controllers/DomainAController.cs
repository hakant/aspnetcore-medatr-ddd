using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MediatR;


namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/DomainA")]
    public class DomainAController : Controller
    {
        private IMediator _mediator;

        public DomainAController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/DomainA/5
        [HttpGet("{name}", Name = "Get")]
        public async Task<string> Get(string name)
        {
            var request = new MarketingDomain.Scenarios.HelloWorld.Request
            {
                Name = name
            };

            var response = await _mediator.Send(request);

            return response.Message;
        }
    }
}
