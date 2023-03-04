using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BakeryQT.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        //dbsets
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Categories> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId = 1, CategoryName = "Work" },
                new Categories { CategoryId = 2, CategoryName = "Friend" },
                new Categories { CategoryId = 3, CategoryName = "Other" },
                new Categories { CategoryId = 4, CategoryName = "Family" }
                );
            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactId = 0, FirstName = "Ryan", LastName = "Lee", Phone = "416-545-1947",
                    Email = "ryan.lee3@georgebrown.ca", CategoryId = 1, DateAdded = DateTime.Now});
        }
    }
}
