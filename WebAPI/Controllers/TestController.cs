using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController(IClassTest test) : ControllerBase
    {

        [HttpGet("Test")]
        public IActionResult Test()
        {
            test.test();
            var a = Request.Headers;
            return Ok();
        }
    }
}