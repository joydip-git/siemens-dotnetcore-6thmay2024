using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAspNetCoreApp.controller
{
    [Route("siemens/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("message")]
        public string GetData()
        {
            return "Hello world";
        }
        [HttpGet("message/{data}")]
        public string GetData(string data)
        {
            return "Hello world " + data;
        }
    }
}
