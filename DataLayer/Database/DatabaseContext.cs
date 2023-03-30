using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace DataLayer.Database
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source=(databasePath)");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            // Create a user
            var user = new DatabaseUser()
            {
                Id = 1,
                Name = "John Doe",
                Password = "1234",
                Role = UserRolesEnum.ADMIN,
                Expires = DateTime.Now.AddYears(10)
            };

            modelBuilder.Entity<DatabaseUser>().HasData(user);

            // Create a user
            var user1 = new DatabaseUser()
            {
                Id = 2,
                Name = "Jane Doe",
                Password = "12",
                Role = UserRolesEnum.PROFESSOR,
                Expires = DateTime.Now.AddYears(1)
            };

            modelBuilder.Entity<DatabaseUser>().HasData(user1);

            // Create a user
            var user2 = new DatabaseUser()
            {
                Id = 3,
                Name = "Josh Dope",
                Password = "12345",
                Role = UserRolesEnum.STUDENT,
                Expires = DateTime.Now.AddDays(10)
            };

            modelBuilder.Entity<DatabaseUser>().HasData(user2);

            // Create a user
            var user3 = new DatabaseUser()
            {
                Id = 4,
                Name = "Ben Dover",
                Password = "123456",
                Role = UserRolesEnum.INSPECTOR,
                Expires = DateTime.Now.AddMonths(10)
            };

            modelBuilder.Entity<DatabaseUser>().HasData(user3);
        }
    }
}
