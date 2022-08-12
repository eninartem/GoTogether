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
        public async Task<IActionResult> GetAllAsync()
        {
            var authClient = _httpClientFactory.CreateClient();
            var discoveryDoc = await authClient.GetDiscoveryDocumentAsync("https://localhost:5055");


            return Ok("All Peoples");
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
