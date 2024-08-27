using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("GetDateTimeNow")]
        public IActionResult GetDateTime()
        {
            var obj = new
            {
                Date = DateTime.Now.ToLongDateString(),
                Time = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }
    }
}