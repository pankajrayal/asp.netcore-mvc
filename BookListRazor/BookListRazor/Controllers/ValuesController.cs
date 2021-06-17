using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Values : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = new   { id = 1, name = "Pankaj Rayal" };
            return Ok(employee);
        }
    }
}
