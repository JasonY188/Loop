using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace backend
{
    public class ApiContext: DbContext
    {
        public DbSet<JobList> joblist { get; set; }
        public DbSet<LoopUser> loopuser { get; set; }
        public DbSet<JobApply> jobapply { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
    }
}