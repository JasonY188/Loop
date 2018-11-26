using System;
using System.ComponentModel.DataAnnotations;

namespace backend
{
    
    
        public class LoopUser
        {
            [Key]

            public int      loop_user_id      { get; set; }
            public string   name              { get; set; }

            public string   password          { get; set; }
            public string   email             { get; set; }

        }
    
}