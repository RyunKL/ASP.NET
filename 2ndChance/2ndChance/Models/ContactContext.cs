using Microsoft.EntityFrameworkCore;

namespace _2ndChance.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }
        
        //db sets
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Friend" },
                new Category { CategoryId = 2, Name = "Work" },
                new Category { CategoryId = 3, Name = "Family" },
                new Category { CategoryId = 4, Name = "Other" });

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Charles",
                    LastName = "Woo",
                    Phone = "416-111-2222",
                    Email = "C.W@hotmail.com",
                    CategoryId = 1,
                    Date= DateTime.Now,

                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Lauren",
                    LastName = "Siu",
                    Phone = "416-114-3333",
                    Email = "l.Siu@yahoo.ca",
                    CategoryId = 2,
                    Date = DateTime.Now,

                }
            );
        }
    }
}
