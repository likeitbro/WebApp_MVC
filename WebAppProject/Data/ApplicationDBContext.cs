using Microsoft.EntityFrameworkCore;
using WebAppProject.Models;

namespace WebAppProject.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options)
        {
            
        }

        public DbSet<Category> Categories { get; set; } // Here Categories is the table name

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Drama", DisplayOrder = 1 }, // A problem may occur while sorting
                new Category { Id = 3, Name = "Thriller", DisplayOrder = 2 },
                new Category { Id = 4, Name = "Sci-Fi", DisplayOrder = 3 }
                );
        }
    }
}
