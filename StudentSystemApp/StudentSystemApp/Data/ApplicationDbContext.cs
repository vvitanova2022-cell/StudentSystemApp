using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using StudentSystemApp.Data.Domains;

namespace StudentSystemApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();

        }
        public DbSet<Course> Courses { get; set; } = null;
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; } = null;
        public DbSet<Resource> Resources { get; set; } = null;
        public DbSet<Student> Students { get; set; } = null;
        public DbSet<StudentCourse> StudentCourses { get; set; } = null;





    }
}
