using IdentityModel.Client;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Peoples.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PeopleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            var authClient = _httpClientFactory.CreateClient();
            var discoveryDoc = await authClient.GetDiscoveryDocumentAsync("https://localhost:5055");


            return Ok("All Peoples");
        }
    }
}
