namespace ITStep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupLessons",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        GroupFK = c.Long(),
                        LessonFK = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupFK)
                .ForeignKey("dbo.Lessons", t => t.LessonFK)
                .Index(t => t.GroupFK)
                .Index(t => t.LessonFK);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Firstname = c.String(),
                        Secondname = c.String(),
                        GroupFK = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupFK)
                .Index(t => t.GroupFK);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StudentFK = c.Long(),
                        LessonFK = c.Long(),
                        Mark = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lessons", t => t.LessonFK)
                .ForeignKey("dbo.Students", t => t.StudentFK)
                .Index(t => t.StudentFK)
                .Index(t => t.LessonFK);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GroupFK", "dbo.Groups");
            DropForeignKey("dbo.Marks", "StudentFK", "dbo.Students");
            DropForeignKey("dbo.Marks", "LessonFK", "dbo.Lessons");
            DropForeignKey("dbo.GroupLessons", "LessonFK", "dbo.Lessons");
            DropForeignKey("dbo.GroupLessons", "GroupFK", "dbo.Groups");
            DropIndex("dbo.Marks", new[] { "LessonFK" });
            DropIndex("dbo.Marks", new[] { "StudentFK" });
            DropIndex("dbo.Students", new[] { "GroupFK" });
            DropIndex("dbo.GroupLessons", new[] { "LessonFK" });
            DropIndex("dbo.GroupLessons", new[] { "GroupFK" });
            DropTable("dbo.Lessons");
            DropTable("dbo.Marks");
            DropTable("dbo.Students");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupLessons");
        }
    }
}
