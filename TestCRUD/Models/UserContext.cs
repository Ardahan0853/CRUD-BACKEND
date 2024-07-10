using Microsoft.EntityFrameworkCore;
using TestCRUD.Models;

namespace userContext.Data
{
    public class userContext : DbContext
    {
        public userContext(DbContextOptions<userContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        // Add other DbSet properties for additional tables if needed

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your model if necessary (e.g., relationships, constraints)
            base.OnModelCreating(modelBuilder);
        }
    }
}