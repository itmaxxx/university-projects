using System;
using System.Data.Entity;
using System.Linq;

namespace ITStep.Models
{
    public class DatabaseContext : DbContext
	{
        public DatabaseContext()
			: base("name=DatabaseContext")
		{
        }

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Group)
                .HasForeignKey(e => e.GroupFK);
        }
    }
}