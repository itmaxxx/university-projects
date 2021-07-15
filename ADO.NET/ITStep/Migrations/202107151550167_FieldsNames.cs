namespace ITStep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FieldsNames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GroupLessons", "GroupFK", "dbo.Groups");
            DropForeignKey("dbo.GroupLessons", "LessonFK", "dbo.Lessons");
            DropIndex("dbo.GroupLessons", new[] { "GroupFK" });
            DropIndex("dbo.GroupLessons", new[] { "LessonFK" });
            AddColumn("dbo.Marks", "Score", c => c.Int(nullable: false));
            DropColumn("dbo.Marks", "Mark");
            DropTable("dbo.GroupLessons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GroupLessons",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        GroupFK = c.Long(),
                        LessonFK = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Marks", "Mark", c => c.Int(nullable: false));
            DropColumn("dbo.Marks", "Score");
            CreateIndex("dbo.GroupLessons", "LessonFK");
            CreateIndex("dbo.GroupLessons", "GroupFK");
            AddForeignKey("dbo.GroupLessons", "LessonFK", "dbo.Lessons", "Id");
            AddForeignKey("dbo.GroupLessons", "GroupFK", "dbo.Groups", "Id");
        }
    }
}
