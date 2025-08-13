using Microsoft.EntityFrameworkCore;

namespace StudentManagementApp.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }
    }
}

