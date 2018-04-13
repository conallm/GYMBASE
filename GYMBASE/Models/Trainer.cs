using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GYMBASE.Models
{
    public class Trainer
    {
        public int TrainerID { get; set; }

        [Required (ErrorMessage="First Name is required")]
        [StringLength(30, MinimumLength = 3,
        ErrorMessage = "Name Should be minimum 3 characters and a maximum of 30 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(30, MinimumLength = 3,
        ErrorMessage = "Name Should be minimum 3 characters and a maximum of 30 characters")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Salary { get; set; }

        //one gym class to a trainer relationship
        public int? GymClassID { get; set; }
        public GymClass GymClass { get; set; }
    }
}