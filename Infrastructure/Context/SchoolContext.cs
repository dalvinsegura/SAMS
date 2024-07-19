using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infrastructure.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().ToTable("Teacher").HasKey(t => t.Id).HasName("TeacherId");
            modelBuilder.Entity<Student>().ToTable("Student").HasKey(s => s.Id).HasName("StudentId");
            modelBuilder.Entity<Class>().ToTable("Class").HasKey(c => c.Id).HasName("ClassId");
            modelBuilder.Entity<Attendance>().ToTable("Attendance").HasKey(a => a.Id).HasName("AttendanceId");
        }


       
    }
}
