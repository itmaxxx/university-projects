namespace ITStep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMark : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Marks", "Lesson_Id", "dbo.Lessons");
            DropForeignKey("dbo.Marks", "Student_Id", "dbo.Students");
            DropIndex("dbo.Marks", new[] { "Lesson_Id" });
            DropIndex("dbo.Marks", new[] { "Student_Id" });
            DropColumn("dbo.Marks", "Lesson_Id");
            DropColumn("dbo.Marks", "Student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Marks", "Student_Id", c => c.Int());
            AddColumn("dbo.Marks", "Lesson_Id", c => c.Int());
            CreateIndex("dbo.Marks", "Student_Id");
            CreateIndex("dbo.Marks", "Lesson_Id");
            AddForeignKey("dbo.Marks", "Student_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.Marks", "Lesson_Id", "dbo.Lessons", "Id");
        }
    }
}
