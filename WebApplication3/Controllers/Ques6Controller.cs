using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques6Controller : ControllerBase
    {
        [HttpGet]
        public double GetHexArea(double side)
        {
            //calculating the area or a hexagon using datatype double and returniing double as result
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return area;
        }
    }
}
