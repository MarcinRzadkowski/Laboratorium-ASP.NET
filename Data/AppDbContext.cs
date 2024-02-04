using Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public DbSet<ContactEntity> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=d:\contacts.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            string ADMIN_ID = Guid.NewGuid().ToString();
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();            
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            // utworzenie roli
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    Id = ADMIN_ROLE_ID,
                    ConcurrencyStamp = ADMIN_ROLE_ID
                }
                );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Name = "user",
                    NormalizedName = "USER",
                    Id = USER_ROLE_ID,
                    ConcurrencyStamp = USER_ROLE_ID
                }
                );

            //UTworzenie użytkownika z rolą 
            var admin = new IdentityUser()
            {
                Id = ADMIN_ID,
                Email = "admin@wsei.edu.pl",
                NormalizedEmail = "ADMIN@WSEI.EDU.PL",
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
            };

            var user = new IdentityUser()
            {
                Id = USER_ID,
                Email = "user@wsei.edu.pl",
                NormalizedEmail = "USER@WSEI.EDU.PL",
                EmailConfirmed = true,
                UserName = "user",
                NormalizedUserName = "USER",
            };
            //hasszowanie hasła admina
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = ph.HashPassword(admin, "abcd");

            //haszowanie hasła usera
            user.PasswordHash = ph.HashPassword(user, "password");

            // dodanie administratora do listy użytkowaników
            modelBuilder.Entity<IdentityUser>().HasData(admin);

            //dodanie usera do listy użytkowników
            modelBuilder.Entity<IdentityUser>().HasData(user);

            // przypisanie administratorowi roli admina
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = ADMIN_ID,
                }
                );
            //przypisanie roli dla usera
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = USER_ID,
                }
                );

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