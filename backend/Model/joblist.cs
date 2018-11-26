using System;
using System.ComponentModel.DataAnnotations;

namespace backend
{
    
    
        public class JobList
        {
            [Key]

            public int      joblist_id            { get; set; }
            public string   post_date             { get; set; }
            public string   company_name          { get; set; }
            public string   job_title             { get; set; }
            public string   job_requirement       { get; set; }
            public string   contact_person        { get; set; }

        }
    
}