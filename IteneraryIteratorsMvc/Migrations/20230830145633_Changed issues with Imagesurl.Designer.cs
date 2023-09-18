﻿// <auto-generated />
using System;
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
    [Migration("20230830145633_Changed issues with Imagesurl")]
    partial class ChangedissueswithImagesurl
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

                    b.Property<string>("ImageUrl")
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
                            ImageUrl = "/Image/Vasamusset.jpg",
                            Name = "Vasamuseet"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "",
                            ImageUrl = "/Image/Skansen.jpg",
                            Name = "Skansen"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Description = "",
                            ImageUrl = "/Image/Bonnier.jpg",
                            Name = "Bonniers konsthall"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "",
                            ImageUrl = "/Image/Liseberg.jpg",
                            Name = "Liseberg"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Description = "",
                            ImageUrl = "/Image/Slottskogen.jpg",
                            Name = "Slottsskogen"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            Description = "",
                            ImageUrl = "/Image/Maritiman.jpg",
                            Name = "Maritiman"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 3,
                            Description = "",
                            ImageUrl = "/Image/Linnetradgarden.jpg",
                            Name = "Linnéträdgården"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 3,
                            Description = "",
                            ImageUrl = "/Image/Botaniska_Tradgarden.jpg",
                            Name = "Botaniska Trädgården"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 3,
                            Description = "",
                            ImageUrl = "/Image/Uppsala_domkyrka.jpg",
                            Name = "Uppsala Domkyrka"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 4,
                            Description = "",
                            ImageUrl = "/Image/Kungsparken-Malmo.jpg",
                            Name = "Kungsparken"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 4,
                            Description = "",
                            ImageUrl = "/Image/MalmoBikeTour.jpg",
                            Name = "Malmö Private Bike Tour"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 4,
                            Description = "",
                            ImageUrl = "/Image/MalmoHusSlott.jpg",
                            Name = "Malmöhus slott"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 5,
                            Description = "",
                            ImageUrl = "/Image/AuroraSkyStation-Kiruna.jpg",
                            Name = "Aurora Sky Station"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 5,
                            Description = "",
                            ImageUrl = "/Image/Silverfallet-Kiruna.jpg",
                            Name = "Silverfallet"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 5,
                            Description = "",
                            ImageUrl = "/Image/LKABVisitorCenter-Kiruna.jpg",
                            Name = "LKAB:s Visitor Centre"
                        });
                });

            modelBuilder.Entity("IteneraryIteratorsMvc.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
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

                    b.Property<string>("ImageUrl")
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
                            ImageUrl = "/Image/Mahalo.jpg",
                            Name = "Mahalo"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "",
                            ImageUrl = "/Image/linglong.jpg",
                            Name = "Linglong"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Description = "",
                            ImageUrl = "/Image/Tranan.jpg",
                            Name = "Tranan"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Description = "",
                            ImageUrl = "/Image/Daawat.jpg",
                            Name = "Daawat"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 2,
                            Description = "",
                            ImageUrl = "/Image/Panos.jpg",
                            Name = "Panos Panos Tavern"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            Description = "",
                            ImageUrl = "/Image/Bord27.jpg",
                            Name = "Bord 27"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 3,
                            Description = "",
                            ImageUrl = "/Image/Aaltos.jpg",
                            Name = "Aaltos Italian Grill & Garden"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 3,
                            Description = "",
                            ImageUrl = "/Image/yHambergs.jpg",
                            Name = "Hambergs Fisk"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 3,
                            Description = "",
                            ImageUrl = "/Image/Missvoon.jpg",
                            Name = "Miss Voon"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 4,
                            Description = "",
                            ImageUrl = "/Image/vollners.jpg",
                            Name = "Vollmers"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 4,
                            Description = "",
                            ImageUrl = "/Image/Aster.jpg",
                            Name = "Aster"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 4,
                            Description = "",
                            ImageUrl = "/Image/Lyran.jpg",
                            Name = "Lyran Matbar"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 5,
                            Description = "",
                            ImageUrl = "/Image/Annis.jpg",
                            Name = "Annis Grill"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 5,
                            Description = "",
                            ImageUrl = "/Image/Enok.jpg",
                            Name = "Enoks i Láddjujávri"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 5,
                            Description = "",
                            ImageUrl = "/Image/Nikkalukta.jpg",
                            Name = "Nikkaluokta Sarri"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IteneraryIteratorsMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IteneraryIteratorsMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IteneraryIteratorsMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IteneraryIteratorsMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
