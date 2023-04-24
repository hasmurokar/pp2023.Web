using Microsoft.EntityFrameworkCore;
using pp2023.Web.Models.Domain;
using pp2023.Web.Pages.Domain;

namespace pp2023.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Dish> Dishes { get; set; }
        //public DbSet<History> Histories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Property(u => u.Role).HasConversion<string>();
        }
    }
}
