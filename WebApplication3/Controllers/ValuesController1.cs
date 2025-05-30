using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Question2con.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController1 : ControllerBase
    {
        [HttpPost]
        public string post(string mess)
        {
            string Message = "This is post Request";
            return Message;
        }
    }
}
