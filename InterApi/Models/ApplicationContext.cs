using InterApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace InterApi.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=InerApi.db");
            }
        }

        public DbSet<UserEntity> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        }
    }
}
