
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
   
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer(@"Server=.;Database=TestDb;Integrated Security=True;");

        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });

        modelBuilder
             .Entity<Student>()
             .HasMany(s => s.Courses)
             .WithOne(sc => sc.Student)
             .HasForeignKey(sc => sc.StudentId);

        modelBuilder
            .Entity<Course>()
            .HasMany(c => c.Students)
            .WithOne(sc => sc.Course)
            .HasForeignKey(c => c.CourseId);

    }
}

