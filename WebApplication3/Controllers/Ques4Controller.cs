using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques4Controller : ControllerBase
    {
        //post request created
        [HttpPost]
        public string Post()
        {
            //returns a string to post
            return "Who’s there?";
        }
    }
}
