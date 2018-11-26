using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend
{
    
    
        public class JobApply
        {
            [Key]

            public int      jobapply_id                { get; set; }
            public string   date_apply                 { get; set; }
            public string   date_respond               { get; set; }
            public bool   move_forward               { get; set; }
            public string   phone_interview_date       { get; set; }
            public string   first_interview_date       { get; set; }
            public string   second_interview_date      { get; set; }
            public string   third_interview_date       { get; set; }
            public string   offer_date                 { get; set;}
            public bool  acceptance                 { get; set; }

            [ForeignKey("joblist_id")]
            public JobList joblist { get; set; }

            [ForeignKey("loop_user_id")]
            public LoopUser loopuser { get; set; }               

            
            
        }
    
}