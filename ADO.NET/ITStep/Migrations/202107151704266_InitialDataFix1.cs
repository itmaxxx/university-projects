namespace ITStep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDataFix1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "GroupFK", "dbo.Groups");
            DropForeignKey("dbo.Marks", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Marks", "Lesson_Id", "dbo.Lessons");
            DropIndex("dbo.Students", new[] { "GroupFK" });
            DropIndex("dbo.Marks", new[] { "Lesson_Id" });
            DropIndex("dbo.Marks", new[] { "Student_Id" });
            DropPrimaryKey("dbo.Groups");
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Lessons");
            DropPrimaryKey("dbo.Marks");
            AlterColumn("dbo.Groups", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Students", "GroupFK", c => c.Int());
            AlterColumn("dbo.Lessons", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Marks", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Marks", "StudentFK", c => c.Int());
            AlterColumn("dbo.Marks", "LessonFK", c => c.Int());
            AlterColumn("dbo.Marks", "Lesson_Id", c => c.Int());
            AlterColumn("dbo.Marks", "Student_Id", c => c.Int());
            AddPrimaryKey("dbo.Groups", "Id");
            AddPrimaryKey("dbo.Students", "Id");
            AddPrimaryKey("dbo.Lessons", "Id");
            AddPrimaryKey("dbo.Marks", "Id");
            CreateIndex("dbo.Students", "GroupFK");
            CreateIndex("dbo.Marks", "Lesson_Id");
            CreateIndex("dbo.Marks", "Student_Id");
            AddForeignKey("dbo.Students", "GroupFK", "dbo.Groups", "Id");
            AddForeignKey("dbo.Marks", "Student_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.Marks", "Lesson_Id", "dbo.Lessons", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Marks", "Lesson_Id", "dbo.Lessons");
            DropForeignKey("dbo.Marks", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "GroupFK", "dbo.Groups");
            DropIndex("dbo.Marks", new[] { "Student_Id" });
            DropIndex("dbo.Marks", new[] { "Lesson_Id" });
            DropIndex("dbo.Students", new[] { "GroupFK" });
            DropPrimaryKey("dbo.Marks");
            DropPrimaryKey("dbo.Lessons");
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Groups");
            AlterColumn("dbo.Marks", "Student_Id", c => c.Long());
            AlterColumn("dbo.Marks", "Lesson_Id", c => c.Long());
            AlterColumn("dbo.Marks", "LessonFK", c => c.Long());
            AlterColumn("dbo.Marks", "StudentFK", c => c.Long());
            AlterColumn("dbo.Marks", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Lessons", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Students", "GroupFK", c => c.Long());
            AlterColumn("dbo.Students", "Id", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.Groups", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Marks", "Id");
            AddPrimaryKey("dbo.Lessons", "Id");
            AddPrimaryKey("dbo.Students", "Id");
            AddPrimaryKey("dbo.Groups", "Id");
            CreateIndex("dbo.Marks", "Student_Id");
            CreateIndex("dbo.Marks", "Lesson_Id");
            CreateIndex("dbo.Students", "GroupFK");
            AddForeignKey("dbo.Marks", "Lesson_Id", "dbo.Lessons", "Id");
            AddForeignKey("dbo.Marks", "Student_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.Students", "GroupFK", "dbo.Groups", "Id");
        }
    }
}
