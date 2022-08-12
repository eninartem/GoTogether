using IdentityModel.Client;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using Peoples.Application.CQRS.Profiles.Commands.CreateGtProfile;

namespace Peoples.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMediator _mediator;

        public PeopleController(IHttpClientFactory httpClientFactory, IMediator mediator)
        {
            _httpClientFactory = httpClientFactory;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var authClient = _httpClientFactory.CreateClient();
            var discoveryDoc = await authClient.GetDiscoveryDocumentAsync("https://localhost:5055");


            return Ok("All Peoples");
        }

        [HttpPost]
        public async Task<IActionResult> CreateGtProfile(CreateGtProfileCommand profileCommand)
        {
            var result = await _mediator.Send(profileCommand);

            return Ok(result);
        }
    }
}
