using CollegeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CollegeManagement.DAL
{
    public class CollegeContext : DbContext
    {

        public CollegeContext() : base("CollegeContext")
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Teacher>().HasKey(e => e.ID);
            modelBuilder.Entity<Teacher>().Property(e => e.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Student>().HasKey(e => e.ID);
            modelBuilder.Entity<Student>().Property(e => e.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Grade>().HasKey(e => e.ID);
            modelBuilder.Entity<Grade>().Property(e => e.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Enrollment>().HasKey(e => e.EnrollmentID);
            modelBuilder.Entity<Enrollment>().Property(e => e.EnrollmentID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Subject>().HasKey(e => e.SubjectID);
            modelBuilder.Entity<Subject>().Property(e => e.SubjectID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Course>().HasKey(e => e.CourseID);
            modelBuilder.Entity<Course>().Property(e => e.CourseID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}