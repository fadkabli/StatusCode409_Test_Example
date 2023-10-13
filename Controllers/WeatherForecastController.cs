using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StatusCode409Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Here, we are returning a 409 Conflict status code.
            return StatusCode(StatusCodes.Status409Conflict, "Custom 409 Response: Conflict occurred");
        }
    }
}
