using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GYMBASE.Models
{
    public class Facility
    {
            public int FacilityID { get; set; }

            [Required(ErrorMessage = "Please enter Facility Name")]
            [StringLength(30, MinimumLength = 3,
            ErrorMessage = "Name Should be minimum 3 characters and a maximum of 30 characters")]
            public string Name { get; set; }

        }
}