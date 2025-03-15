using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<CourseEnrollment> CourseEnrollments => Set<CourseEnrollment>();
    }
}