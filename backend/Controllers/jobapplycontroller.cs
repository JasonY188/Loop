using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    [Route("api/jobapply")]
    [ApiController]
    public class JobApplyController : ControllerBase
    {
        public ApiContext _context { get; set; }

        public JobApplyController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            //return Ok("you hit the jobapply api");
            return Ok(_context.jobapply.Include("joblist").Include("loopuser").ToList());
        }
    }    
}
