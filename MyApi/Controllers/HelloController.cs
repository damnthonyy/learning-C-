using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet()]
        public IActionResult SayHello()
        {
            return Ok("Hello, my Api is running");
        }

        [HttpGet("{name}")]
        public IActionResult HelloName(string name)
        {
            return Ok($"Hello {name}");
        }

        [HttpPost]
        public IActionResult HelloPost([FromBody] HelloRequest request)
        {
            var response = new HelloResponse()
            {
                Message = $"Hello {request.Name}"
            };
            return Ok(response);
        }
    }   
}
