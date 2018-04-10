using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GYMBASE.Models
{
    public class Member
    {
        
            // declare variables of Member class (entity)
            public int MemberId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public int Tier { get; set; }

            //set foreign key for classes - a member may not sign up to any classes so FK is nullable
            public int? GymClassID { get; set;}
        }
}