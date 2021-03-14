////////////////////////////////////////////////////////////////////////////////
///DATE         DEVELOPER               DESCRIPTION
///2021-03-13   logan23b                class created
//added data file
//added schoolcontext class
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    //tinfo200:[2021-03-11-logan23b-dykstra1] - added class schoolContext which is extending DbContext
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //tinfo200:[2021-03-11-logan23b-dykstra1] - Added DB sets for courses, enrollments, and students that represents each entity
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }


        //tinfo200:[2021-03-11-logan23b-dykstra1] - added method OnModelCreating which names tables
        //tinfo200:[2021-03-11-logan23b-dykstra1] - telling entity framework what names to give to the tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}