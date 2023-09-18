﻿// <auto-generated />
using IteneraryIteratorsMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IteneraryIteratorsMvc.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230829085146_Initial migration")]
    partial class Initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IteneraryIteratorsMvc.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "",
                            Name = "Vasamuseet"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "",
                            Name = "Skansen"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Description = "",
                            Name = "Bonniers konsthall"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "",
                            Name = "Liseberg"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Description = "",
                            Name = "Slottsskogen"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            Description = "",
                            Name = "Maritiman"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 3,
                            Description = "",
                            Name = "Linnéträdgården"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 3,
                            Description = "",
                            Name = "Botaniska Trädgården"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 3,
                            Description = "",
                            Name = "Uppsala Domkyrka"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 4,
                            Description = "",
                            Name = "Kungsparken"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 4,
                            Description = "",
                            Name = "Malmö Private Bike Tour"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 4,
                            Description = "",
                            Name = "Malmöhus slott"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 5,
                            Description = "",
                            Name = "Aurora Sky Station"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 5,
                            Description = "",
                            Name = "Silverfallet"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 5,
                            Description = "",
                            Name = "LKAB:s Visitor Centre"
                        });
                });

            modelBuilder.Entity("IteneraryIteratorsMvc.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Göteborg"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Uppsala"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Malmö"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Kiruna"
                        });
                });

            modelBuilder.Entity("IteneraryIteratorsMvc.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "",
                            Name = "Mahalo"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "",
                            Name = "Linglong"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Description = "",
                            Name = "Tranan"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "",
                            Name = "Daawat"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Description = "",
                            Name = "Panos Panos Tavern"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            Description = "",
                            Name = "Bord 27"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 3,
                            Description = "",
                            Name = "Aaltos Italian Grill & Garden"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 3,
                            Description = "",
                            Name = "Hambergs Fisk"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 3,
                            Description = "",
                            Name = "Miss Voon"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 4,
                            Description = "",
                            Name = "Vollmers"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 4,
                            Description = "",
                            Name = "Aster"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 4,
                            Description = "",
                            Name = "Lyran Matbar"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 5,
                            Description = "",
                            Name = "Annis Grill"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 5,
                            Description = "",
                            Name = "Enoks i Láddjujávri"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 5,
                            Description = "",
                            Name = "Nikkaluokta Sarri"
                        });
                });

            modelBuilder.Entity("IteneraryIteratorsMvc.Models.Activity", b =>
                {
                    b.HasOne("IteneraryIteratorsMvc.Models.City", "City")
                        .WithMany("Activities")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("IteneraryIteratorsMvc.Models.Restaurant", b =>
                {
                    b.HasOne("IteneraryIteratorsMvc.Models.City", "City")
                        .WithMany("Restaurants")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("IteneraryIteratorsMvc.Models.City", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
