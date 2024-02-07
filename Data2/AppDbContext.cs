using Data2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Data2
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<EmployeeEntity> Employees { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=d:\contacts.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();
            //string USER_ID = Guid.NewGuid().ToString();
            //string USER_ROLE_ID = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    Id = ROLE_ID,
                    ConcurrencyStamp = ROLE_ID
                });

            //modelBuilder.Entity<IdentityRole>().HasData(
            //    new IdentityRole()
            //    {
            //        Name = "user",
            //        NormalizedName = "USER",
            //        Id = USER_ROLE_ID,
            //        ConcurrencyStamp = USER_ROLE_ID
            //    }
            //    );

            var admin = new IdentityUser()
            {
                Id = ADMIN_ID,
                Email = "admin@wsei.edu.pl",
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADMIN@WSEI.EDU.PL"
            };

            //var user = new IdentityUser()
            //{
            //    Id = USER_ID,
            //    Email = "user@wsei.edu.pl",
            //    NormalizedEmail = "USER@WSEI.EDU.PL",
            //    EmailConfirmed = true,
            //    UserName = "user",
            //    NormalizedUserName = "USER",
            //};

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = ph.HashPassword(admin, "123abc!ABC");
            modelBuilder.Entity<IdentityRole>().HasData(admin);

            //user.PasswordHash = ph.HashPassword(user, "password");
            //modelBuilder.Entity<IdentityUser>().HasData(user);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID
                });

            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>
            //    {
            //        RoleId = USER_ROLE_ID,
            //        UserId = USER_ID,
            //    }
            //    );

            modelBuilder.Entity<EmployeeEntity>().HasData(
                new EmployeeEntity()
                {
                    EmployeeId = 1,
                    FirstName = "Jan",
                    LastName = "Nowak",
                    PESEL = "8902137123",
                    Position = "Manager",
                    Departament = Departament.Sales,
                    DateOfEmployment = "11.10.2008"
                },
                new EmployeeEntity()
                {
                    EmployeeId = 2,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    PESEL = "6902137420",
                    Position = "Manager",
                    Departament = Departament.Sales,
                    DateOfEmployment = "13.05.2004",
                    ReleaseDate = "11.10.2008"
                }
                );
        }
    }
}