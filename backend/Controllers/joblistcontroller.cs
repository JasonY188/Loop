using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    [Route("api/joblist")]
    [ApiController]
    public class JobListController : ControllerBase
    {
        public ApiContext _context { get; set; }

        public JobListController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            // return Ok("you hit the api");
            return Ok(_context.joblist.ToList());
        }
        [HttpPost]
       
        public IActionResult Post([FromBody]JobList p)
        {
            if (p == null)
            {
                return BadRequest();
            }
            

            _context.joblist.Add(p);
            _context.SaveChanges();
            return Ok(p);
        }
    }    
}
