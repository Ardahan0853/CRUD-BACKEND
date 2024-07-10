using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace TestCRUD.Models
{
    public class RegisterContext : DbContext
    {
        public RegisterContext(DbContextOptions<RegisterContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } // Add this line


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add any model configuration here
        }
    }
}
