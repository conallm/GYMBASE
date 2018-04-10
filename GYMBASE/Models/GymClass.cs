using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GYMBASE.Models
{
    public class GymClass
    {
        public int GymClassID { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }

        //establish foreign key identity for one facility/trainer to many classes relationship


        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}