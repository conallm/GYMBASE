using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GYMBASE.Models
{
    public class GymClass
    {
        public int GymClassID { get; set; }
        [Required(ErrorMessage = "Please enter a Class Name")]
        [StringLength(30, MinimumLength = 3,
        ErrorMessage = "Name Should be minimum 3 characters and a maximum of 30 characters")]
        public string ClassName { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        [StringLength(100, MinimumLength = 3,
        ErrorMessage = "Name Should be minimum 3 characters and a maximum of 30 characters")]
        public string Description { get; set; }

        //establish foreign key identity for one facility/trainer to many classes relationship


        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}