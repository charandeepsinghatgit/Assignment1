﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/Ques5")]
    [ApiController]
    public class Ques5Controller : ControllerBase
    {
        [HttpPost]
        public string Post([FromBody] int secret)
        {
            //returns messasge plus the secret fetched from input value (int)
             return $"Shh.. the secret is {secret}";
        }
    }
}
