using Judge.App.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Judge.App.Data
{
    public class JudgeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contest> Contests { get; set; }
        public DbSet<Submission> Submissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder
                .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=JudgeExamDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder
                .Entity<Submission>()
                .HasOne(s => s.Contest)
                .WithMany(c => c.Submissions)
                .HasForeignKey(s => s.ContestId);

            builder
                .Entity<Submission>()
                .HasOne(s => s.User)
                .WithMany(u => u.Submissions)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder
                .Entity<Contest>()
                .HasOne(c => c.User)
                .WithMany(u => u.Contests)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
