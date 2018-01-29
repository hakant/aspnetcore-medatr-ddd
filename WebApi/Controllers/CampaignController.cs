using MarketingDomain.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Campaign")]
    public class CampaignController : Controller
    {
        private readonly IMediator _mediator;

        public CampaignController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Clients/5
        [HttpGet(Name = "GetClientListForCampaign")]
        public async Task<IEnumerable<Client>> Get()
        {
            var request = new MarketingDomain.Scenarios.GetClientListForCampaign.Request();

            var response = await _mediator.Send(request);

            return response.Clients;
        }
    }
}
