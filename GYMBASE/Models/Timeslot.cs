using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GYMBASE.Models
{
    public class Timeslot
    {
        public int TimeslotID { get; set; }
        [Required]
        public string Time { get; set; }
    }
}