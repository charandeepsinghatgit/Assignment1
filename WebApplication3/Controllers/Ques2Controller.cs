using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques2Controller : ControllerBase
    {
        [HttpGet("greeting")]
        public string Get(string name)
        {
            //this method will  return the message plus the name entered
            return $"Hi {name}!";
        }
    }
}
