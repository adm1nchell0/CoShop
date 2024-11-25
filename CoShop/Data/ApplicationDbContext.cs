using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoShop.Models;

namespace CoShop.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        // DbSet ��� ������ ������
        public DbSet<Pol> Pols { get; set; } = default!;
        //public DbSet<Polzo> Polzos { get; set; } = default!;
        public DbSet<Course> Courses { get; set; } = default!;
        public DbSet<Lesson> Lessons { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;
        public DbSet<Category> Categorys { get; set; } = default!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ����� ����� Pol � Polzo (���� �� ������)
            modelBuilder.Entity<Pol>()
                .HasMany(u => u.ApplicationUsers)
                .WithOne(o => o.Pol)
                .HasForeignKey(o => o.PolId);

            // ����� ����� Polzo � Order (���� �� ������)
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.ApplicationUser)
                .HasForeignKey(o => o.ApplicationUserId);

            // ����� ����� Course � Order (���� �� ������)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Orders)
                .WithOne(l => l.Course)
                .HasForeignKey(l => l.CourseId);

            // ����� ����� Course � Lesson (���� �� ������)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Lessons)
                .WithOne(l => l.Course)
                .HasForeignKey(l => l.CourseId);

            // ����� ����� Course � Review (���� �� ������)
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Reviews)
                .WithOne(r => r.Course)
                .HasForeignKey(r => r.CourseId);

            // ����� ����� Polzo � Review (���� �� ������)
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.ApplicationUser)
                .HasForeignKey(r => r.ApplicationUserId);

            // ����� ����� Course � Category (������ � ������)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Courses)
                .WithOne(cc => cc.Category)
                .HasForeignKey(c => c.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
