using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques4Controller : ControllerBase
    {
        [HttpPost]
        public string Post()
        {
            return "Who’s there?";
        }

        //[HttpPost]
        //public string post()
        //{
        //    string Message = "This is post Request";
        //    return Message;
        //}
    }
}
