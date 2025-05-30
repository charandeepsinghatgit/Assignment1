using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ques8Controller : ControllerBase
    {
         [HttpPost]
        public IActionResult Calculate([FromForm] int Small, [FromForm] int Large)
        {
            //declaring prices
            decimal priceSmall = 25.50m;
            decimal priceLarge = 40.50m;
            decimal taxRate = 0.13m;
            //equations to calculate total smalls, larges, their subtotal and tax and it's total'
            decimal totalSmall = Small * priceSmall;
            decimal totalLarge = Large * priceLarge;
            decimal subtotal = totalSmall + totalLarge;
            decimal tax = subtotal * taxRate;
            decimal total = subtotal + tax;

            //output strings
            string line1 = $"{Small} Small @ {priceSmall:C} = {totalSmall:C}";
            string line2 = $"{Large} Large @ {priceLarge:C} = {totalLarge:C}";
            string line3 = $"Subtotal = {subtotal:C}";
            string line4 = $"Tax = {Math.Round(tax, 2):C} HST";
            string line5 = $"Total = {Math.Round(total, 2):C}";

            string result = $"{line1}; {line2}; {line3}; {line4}; {line5}";
            //returing combined strings to post
            return Content(result);
    }
}
