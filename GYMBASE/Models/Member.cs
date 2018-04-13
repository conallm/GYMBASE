﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GYMBASE.Models
{
    public class Member
    {
        
            // declare variables of Member class (entity)
            public int MemberId { get; set; }

            [Required(ErrorMessage = "First Name is required")]
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
            [Range(1,3, ErrorMessage = "Tier must be a number between 1 and 3")]
            public int Tier { get; set; }

        //set foreign key for classes - a member may not sign up to any classes at all 
        //so FK is nullable

            public int? GymClassID { get; set;}
        }
}