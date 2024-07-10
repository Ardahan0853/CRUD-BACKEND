// Models/PersonContext.cs
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace TestCRUD.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; } // Add this line


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add any model configuration here
        }
    }
}
