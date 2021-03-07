﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(BevContext))]
    [Migration("20210226163232_css")]
    partial class css
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Bev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bevs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Soda",
                            Description = "Smooth caramel beverage.",
                            Image = "Images/coke.jpg",
                            Name = "Coke",
                            Review = " 10/10 Would reccomend."
                        },
                        new
                        {
                            Id = 2,
                            Category = "Soda",
                            Description = "Rough and tumble",
                            Image = "Images/Pepsipic.jpg",
                            Name = "Pepsi",
                            Review = "Disappointing."
                        },
                        new
                        {
                            Id = 3,
                            Category = "Energy Drink",
                            Description = "It gives you wings",
                            Image = "Images/RedBull.jpg",
                            Name = "Red Bull",
                            Review = "Yummy"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Energy Drink",
                            Description = "Energizing drink",
                            Image = "Images/Monster.jpg",
                            Name = "Monster",
                            Review = "It's mediocre"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Sparkling Water",
                            Description = "Many flavors",
                            Image = "Images/LaCroix.jpg",
                            Name = "La Croix",
                            Review = "Refreshlingy bubbly"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Sparkling Water",
                            Description = "Fruit juice flavored sparkling water",
                            Image = "Images/Spindrift.jpg",
                            Name = "SpinDrift",
                            Review = "It's like La Croix's cooler sibling"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BevId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BevId");

                    b.ToTable("ReviewList");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BevId = 1,
                            Content = "Too carbonated.",
                            Rating = "5",
                            ReviewDate = new DateTime(2021, 2, 26, 11, 32, 31, 445, DateTimeKind.Local).AddTicks(8600),
                            ReviewerName = "Carlos"
                        },
                        new
                        {
                            Id = 2,
                            BevId = 2,
                            Content = "Offensive to the pallete",
                            Rating = "0",
                            ReviewDate = new DateTime(2021, 2, 26, 11, 32, 31, 449, DateTimeKind.Local).AddTicks(5205),
                            ReviewerName = "Davis"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Bev", "Bev")
                        .WithMany("Reviews")
                        .HasForeignKey("BevId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bev");
                });

            modelBuilder.Entity("ReviewsSite.Models.Bev", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}