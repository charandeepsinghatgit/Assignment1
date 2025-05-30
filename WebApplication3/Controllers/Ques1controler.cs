using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques1controller : ControllerBase
    {
        [HttpGet("Welcome")]
        public String Get()
        {
            return "Welcome to 5125!";
        }

        //[HttpPost]
        //public string post(string mess)
        //{
        //    string Message = "This is post Request";
        //    return Message;
        //}
        
    }
}
