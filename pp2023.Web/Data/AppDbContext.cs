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
        public DbSet<Histories> Histories { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Users> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserRole>()
        //        .HasKey(bc => new { bc.UserId, bc.RoleId});
        //    modelBuilder.Entity<UserRole>()
        //        .HasOne(bc => bc.UserId)
        //        .WithMany(b => b.UserRoles)
        //        .HasForeignKey(bc => bc.UserId);
        //    modelBuilder.Entity<UserRole>()
        //        .HasOne(bc => bc.RoleId)
        //        .WithMany(c => c.UserRoles)
        //        .HasForeignKey(bc => bc.RoleId);
        //}
    }
}
