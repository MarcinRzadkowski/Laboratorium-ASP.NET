using Data_App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Data_App
{
    public class AppDbContext : DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "employees.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeEntity>().HasData(
                new EmployeeEntity() 
                { 
                    Id =1,
                    FirstName = "Jan",
                    LastName = "Nowak",
                    PESEL = "8902137123",
                    Position = "Manager",
                    Departament = Departament.Sales,
                    DateOfEmployment = "11.10.2008"
                },
                new EmployeeEntity() 
                {
                    Id = 2,
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