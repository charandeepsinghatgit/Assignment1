using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        [HttpGet("Welcome")]
        public ActionResult<String> GetWelcome()
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
