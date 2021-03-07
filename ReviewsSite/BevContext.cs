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
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=BevContext3; Trusted_Connection=True";

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
                    Description = "A sweetened, carbonated soft drink flavored with vanilla, cinnamon, citrus oils and other flavorings. " +
                    "Most contain caffeine, which was originally sourced from the kola nut, leading to the drink's name, though other sources are " +
                    "now also used. Cola became popular worldwide after pharmacist John Pemberton invented Coca-Cola in 1886, which was later imitated by " +
                    "other manufacturers.His non-alcoholic recipe was inspired by the coca wine of pharmacist Angelo Mariani, created in 1863.",

                    Category = "Soda",
                    Review = " 10/10 Would recommend.", 
                    Image = "Images/coke.jpg"
                },
                new Bev()
                {
                    Id = 2,
                    Name = "Pepsi",
                    Description = "Pepsi is a carbonated soft drink manufactured by PepsiCo. " +
                    "Originally created and developed in 1893 by Caleb Bradham and introduced as Brad's Drink, " +
                    "it was renamed as Pepsi-Cola in 1898, and then shortened to Pepsi in 1961.",
                    Category = "Soda",
                    Review = "Disappointing.",
                    Image = "Images/Pepsipic.jpg"
                },
                new Bev()
                {
                    Id = 3,
                    Name = "Red Bull",
                    Description = "Red Bull is an energy drink sold by Red Bull GmbH, an Austrian company created in 1987. " +
                    "Red Bull has the highest market share of any energy drink in the world, " +
                    "with 7.5 billion cans sold in a year (as of 2019).",
                    Category = "Energy Drink",
                    Review = "Yummy",
                    Image = "Images/RedBull.jpg"
                },
                new Bev()
                {
                    Id = 4,
                    Name = "Monster",
                    Description = "Monster Energy is an energy drink that was introduced by Hansen Natural Company " +
                    "in April of 2002. As of 2019, Monster Energy has a 35% share " +
                    "of the energy drink market, the second highest share after Red Bull.",
                    Category = "Energy Drink",
                    Review = "It's mediocre",
                    Image = "Images/Monster.jpg"
                },
                new Bev()
                {
                    Id = 5,
                    Name = "La Croix",
                    Description = "LaCroix or La Croix is an American brand of carbonated water " +
                    "that originated in La Crosse, Wisconsin by G. Heileman Brewing Company and is now distributed " +
                    "by National Beverage Corporation.",
                    Category = "Sparkling Water",
                    Review = "Refreshlingy bubbly",
                    Image = "Images/LaCroix.jpg"
                },
                new Bev()
                {
                    Id = 6,
                    Name = "SpinDrift",
                    Description = "America's first sparkling water made with just real squeezed fruit.",
                    Category = "Sparkling Water",
                    Review = "It's like La Croix's cooler sibling",
                    Image = "Images/Spindrift.jpg"
                }
             );

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Id = 1,
                    Content = "Too carbonated.",
                    ReviewerName = "Carlos",
                    Rating = 5,
                    ReviewDate = DateTime.Now,
                    BevId = 1
                },
                new Review()
                {
                    Id = 2,
                    Content = "Offensive to the pallete",
                    ReviewerName = "Davis",
                    Rating = 0,
                    ReviewDate = DateTime.Now,
                    BevId = 2
                }
             );


        }

    }
}
