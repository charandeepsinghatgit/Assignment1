using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques1controller : ControllerBase
    {
        //a get request 
        [HttpGet("Welcome")]
        public String Get()
        {
            //this method  will return the message
            return "Welcome to 5125!";
        }
    }
}
