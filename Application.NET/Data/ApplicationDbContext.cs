using Application.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.NET.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "test", DisplayOrder = 1 },
                new Category { Id = 2, Name = "test2", DisplayOrder = 2 },
                new Category { Id = 3, Name = "test3", DisplayOrder = 3 }
                );
        }
    }
}
