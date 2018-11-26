using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    [Route("api/loopuser")]
    [ApiController]
    public class LoopUsercontroller : ControllerBase
    {
        public ApiContext _context { get; set; }

        public LoopUsercontroller(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
             //return Ok("you hit the loop user api");
            return Ok(_context.loopuser.ToList());
        }
    }    
}
