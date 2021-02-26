using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;

namespace ReviewsSite
{
    public class BevContext : DbContext
    {
        public DbSet<Bev> Bevs { get; set; }
        public DbSet<Review> ReviewList { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=UniversityDB_102021; Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bev>().HasData(
                new Bev()
                {
                    Id = 1,
                    Name = "Coke",
                    Description = "Smooth caramel beverage.",
                    Category = "Soda",
                    Review = " 10/10 Would reccomend.", 
                    Image = "Images/coke.jpg"
                },
                new Bev()
                {
                    Id = 2,
                    Name = "Pepsi",
                    Description = "Rough and tumble",
                    Category = "Soda",
                    Review = "Disappointing.",
                    Image = "Images/Pepsipic.jpg"
                }
             
             );

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Id = 1,
                    Content = "Too carbonated.",
                    ReviewerName = "Carlos",
                    Rating = "5",
                    ReviewDate = DateTime.Now
                },
                new Review()
                {
                    Id = 2,
                    Content = "Offensive to the pallete",
                    ReviewerName = "Davis",
                    Rating = "0",
                    ReviewDate = DateTime.Now
                }
             );


        }

    }
}
