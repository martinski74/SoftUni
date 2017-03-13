namespace StudentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLicenses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Resources", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Resources", new[] { "Course_Id" });
            CreateTable(
                "dbo.Licenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Resource_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Resources", t => t.Resource_Id)
                .Index(t => t.Resource_Id);
            
            CreateTable(
                "dbo.ResourceCourses",
                c => new
                    {
                        Resource_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Resource_Id, t.Course_Id })
                .ForeignKey("dbo.Resources", t => t.Resource_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Resource_Id)
                .Index(t => t.Course_Id);
            
            DropColumn("dbo.Resources", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "Course_Id", c => c.Int());
            DropForeignKey("dbo.Licenses", "Resource_Id", "dbo.Resources");
            DropForeignKey("dbo.ResourceCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.ResourceCourses", "Resource_Id", "dbo.Resources");
            DropIndex("dbo.ResourceCourses", new[] { "Course_Id" });
            DropIndex("dbo.ResourceCourses", new[] { "Resource_Id" });
            DropIndex("dbo.Licenses", new[] { "Resource_Id" });
            DropTable("dbo.ResourceCourses");
            DropTable("dbo.Licenses");
            CreateIndex("dbo.Resources", "Course_Id");
            AddForeignKey("dbo.Resources", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
