namespace ITStep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialData : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Marks", "LessonFK", "dbo.Lessons");
            DropForeignKey("dbo.Marks", "StudentFK", "dbo.Students");
            DropIndex("dbo.Marks", new[] { "StudentFK" });
            DropIndex("dbo.Marks", new[] { "LessonFK" });
            AddColumn("dbo.Students", "LastName", c => c.String());
            AddColumn("dbo.Marks", "Lesson_Id", c => c.Long());
            AddColumn("dbo.Marks", "Student_Id", c => c.Long());
            CreateIndex("dbo.Marks", "Lesson_Id");
            CreateIndex("dbo.Marks", "Student_Id");
            AddForeignKey("dbo.Marks", "Lesson_Id", "dbo.Lessons", "Id");
            AddForeignKey("dbo.Marks", "Student_Id", "dbo.Students", "Id");
            DropColumn("dbo.Students", "Secondname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Secondname", c => c.String());
            DropForeignKey("dbo.Marks", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Marks", "Lesson_Id", "dbo.Lessons");
            DropIndex("dbo.Marks", new[] { "Student_Id" });
            DropIndex("dbo.Marks", new[] { "Lesson_Id" });
            DropColumn("dbo.Marks", "Student_Id");
            DropColumn("dbo.Marks", "Lesson_Id");
            DropColumn("dbo.Students", "LastName");
            CreateIndex("dbo.Marks", "LessonFK");
            CreateIndex("dbo.Marks", "StudentFK");
            AddForeignKey("dbo.Marks", "StudentFK", "dbo.Students", "Id");
            AddForeignKey("dbo.Marks", "LessonFK", "dbo.Lessons", "Id");
        }
    }
}
