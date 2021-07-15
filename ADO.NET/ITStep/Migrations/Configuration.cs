namespace ITStep.Migrations
{
	using ITStep.Models;
	using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ITStep.Models.DatabaseContext";
        }

        protected override void Seed(DatabaseContext db)
        {
            Group[] groups = new Group[]
            {
                new Group { Id = 1, Name = "KNP-181" },
                new Group { Id = 2, Name = "D-1" }
            };

            Student[] students = new Student[]
            {
                new Student { Id = 1, FirstName = "Max", LastName = "Dmitriev", GroupFK = 1 },
                new Student { Id = 2, FirstName = "Max", LastName = "Gorelik", GroupFK = 2 }
            };

            Subject[] subjects = new Subject[]
            {
                new Subject { Id = 1, Name = "Math" },
                new Subject { Id = 2, Name = "Programming" },
                new Subject { Id = 3, Name = "Design" }
            };

            Mark[] marks = new Mark[]
            {
                new Mark { Id = 1, SubjectFK = 1, StudentFK = 1, Score = 6 },
                new Mark { Id = 2, SubjectFK = 2, StudentFK = 1, Score = 11 },
                new Mark { Id = 3, SubjectFK = 1, StudentFK = 2, Score = 5 },
                new Mark { Id = 4, SubjectFK = 3, StudentFK = 2, Score = 12 },
            };

            db.Groups.AddRange(groups);
            db.Students.AddRange(students);
            db.Subjects.AddRange(subjects);
            db.Marks.AddRange(marks);

            db.SaveChanges();
        }
    }
}
