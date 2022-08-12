using Peoples.Application.CQRS.Profiles.Queries.GetGtProfile;
using Peoples.Application.CQRS.Profiles.Queries.GetGtProfileList;

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
        public async Task<IActionResult> GetGtProfileListAsync()
        {
            var list = await _mediator.Send(new GetGtProfileListQuery());

            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGtProfileAsync(Guid id)
        {
            var command = new GetGtProfileQuery() { Id = id };

            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGtProfileAsync(UpdateGtProfileCommand profileCommand)
        {
            await _mediator.Send(profileCommand);

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGtProfileAsync(CreateGtProfileCommand profileCommand)
        {
            var result = await _mediator.Send(profileCommand);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGtProfileAsync(Guid id)
        {
            var command = new DeleteGtProfileCommand() { Id = id };

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
