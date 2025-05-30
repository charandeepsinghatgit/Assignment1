using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques7Controller : ControllerBase
    {
        [HttpGet]
        public string GetAdjustedDate(int days)
        {

            DateTime today = DateTime.Today;
            DateTime NewDate = today.AddDays(days);
            return NewDate.ToString("yyyy-MM-dd");
        }
    }
}
