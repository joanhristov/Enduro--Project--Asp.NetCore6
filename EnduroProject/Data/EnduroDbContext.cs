namespace EnduroProject.Data
{
    using EnduroProject.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class EnduroDbContext : IdentityDbContext
    {
        public EnduroDbContext(DbContextOptions<EnduroDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; init; }

        public DbSet<Category> Category { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Event>()
                .HasOne(e => e.Category)
                .WithMany(c => c.Events)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}