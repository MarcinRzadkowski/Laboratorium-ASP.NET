using Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=d:\contacts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>()
                .HasKey(e => e.ContactId);
            modelBuilder.Entity<ContactEntity>()
                .HasData(
                    new ContactEntity()
                    {
                        ContactId = 1,
                        Name = "Test",
                        Email = "test@wsei.edu.pl",
                        Phone = "123456789"
                    },
                    new ContactEntity()
                    {
                        ContactId = 2,
                        Name = "Adam",
                        Email = "adam@wsei.edu.pl",
                        Birth = new DateTime(200, 10, 01)
                    }
                );
        }
    }
}