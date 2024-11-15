using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoShop.Models;

namespace CoShop.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        // DbSet для каждой модели
        public DbSet<Pol> Pols { get; set; } = default!;
        public DbSet<Polzo> Polzos { get; set; } = default!;
        public DbSet<Course> Courses { get; set; } = default!;
        public DbSet<Lesson> Lessons { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;
        public DbSet<Category> Categorys { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Связь между Pol и Polzo (один ко многим)
            modelBuilder.Entity<Pol>()
                .HasMany(u => u.Polzos)
                .WithOne(o => o.Pol)
                .HasForeignKey(o => o.PolId);

            // Связь между Polzo и Order (один ко многим)
            modelBuilder.Entity<Polzo>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.Polzo)
                .HasForeignKey(o => o.PolzoId);

            // Связь между Course и Order (один ко многим)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Orders)
                .WithOne(l => l.Course)
                .HasForeignKey(l => l.CourseId);

            // Связь между Course и Lesson (один ко многим)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Lessons)
                .WithOne(l => l.Course)
                .HasForeignKey(l => l.CourseId);

            // Связь между Course и Review (один ко многим)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Reviews)
                .WithOne(r => r.Course)
                .HasForeignKey(r => r.CourseId);

            // Связь между Polzo и Review (один ко многим)
            modelBuilder.Entity<Polzo>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.Polzo)
                .HasForeignKey(r => r.PolzoId);

            // Связь между Course и Category (многие к одному)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Courses)
                .WithOne(cc => cc.Category)
                .HasForeignKey(c => c.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
