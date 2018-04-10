namespace GYMBASE.Migrations.Gymbase
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        FacilityID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GymClass_GymClassID = c.Int(),
                    })
                .PrimaryKey(t => t.FacilityID)
                .ForeignKey("dbo.GymClasses", t => t.GymClass_GymClassID)
                .Index(t => t.GymClass_GymClassID);
            
            CreateTable(
                "dbo.GymClasses",
                c => new
                    {
                        GymClassID = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GymClassID);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        TrainerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Salary = c.Int(nullable: false),
                        GymClassID = c.Int(),
                    })
                .PrimaryKey(t => t.TrainerID)
                .ForeignKey("dbo.GymClasses", t => t.GymClassID)
                .Index(t => t.GymClassID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Tier = c.Int(nullable: false),
                        GymClassID = c.Int(),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.Timeslots",
                c => new
                    {
                        TimeslotID = c.Int(nullable: false, identity: true),
                        Time = c.String(),
                    })
                .PrimaryKey(t => t.TimeslotID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainers", "GymClassID", "dbo.GymClasses");
            DropForeignKey("dbo.Facilities", "GymClass_GymClassID", "dbo.GymClasses");
            DropIndex("dbo.Trainers", new[] { "GymClassID" });
            DropIndex("dbo.Facilities", new[] { "GymClass_GymClassID" });
            DropTable("dbo.Timeslots");
            DropTable("dbo.Members");
            DropTable("dbo.Trainers");
            DropTable("dbo.GymClasses");
            DropTable("dbo.Facilities");
        }
    }
}
