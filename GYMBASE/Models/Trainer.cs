using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GYMBASE.Models
{
    public class Trainer
    {
        public int TrainerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        //one gym class to a trainer relationship
        public int? GymClassID { get; set; }
        public GymClass GymClass { get; set; }
    }
}