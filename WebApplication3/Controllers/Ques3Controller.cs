using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques3Controller : ControllerBase
    {
        [HttpGet]
        public int Get(int Value)
        {
            //this method  will return int cube of value calculated like below
            int result = Value * Value * Value;
            return result;
        }
    }
}
