using GYMBASE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace GYMBASE.Data
{

    public class GymbaseContext : DbContext
    {
        public GymbaseContext() : base("DefaultConnection")
        { }
        public DbSet<Member> Members { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<GymClass> GymClasses { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        

        }
    }