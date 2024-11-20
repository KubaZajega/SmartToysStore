using Microsoft.EntityFrameworkCore;
using SmartToysStore.Models;

namespace SmartToysStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Interactive", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Puzzle", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Feeder", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Waterer", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Plush", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Travel", DisplayOrder = 6 }
            );
        }
    }
};