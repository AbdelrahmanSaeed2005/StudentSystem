using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.dataAccess
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resources> Resources { get; set; }
        //public DbSet<HomeworkSubmissions> HomeworkSubmissions { get; set; }
        public DbSet<HomeworkSubmissions> HomeworkSubmissions { get; set; }
        public DbSet<StudentCorse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog = Student System;Integrated Security=True;TrustServerCertificate=True");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCorse>()
              .HasKey(sc => new { sc.StudentId, sc.CourseId });
        }

    }
}
