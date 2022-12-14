// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShareBuildersProject_DataAccess.Data;

#nullable disable

namespace ShareBuildersProject_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221112022904_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Composite.AffiliateComposite", b =>
                {
                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.Property<int>("AffiliateId")
                        .HasColumnType("int");

                    b.HasKey("StationId", "AffiliateId");

                    b.ToTable("AffiliateComposites");

                    b.HasData(
                        new
                        {
                            StationId = 1,
                            AffiliateId = 1
                        },
                        new
                        {
                            StationId = 1,
                            AffiliateId = 2
                        },
                        new
                        {
                            StationId = 1,
                            AffiliateId = 3
                        },
                        new
                        {
                            StationId = 1,
                            AffiliateId = 4
                        },
                        new
                        {
                            StationId = 2,
                            AffiliateId = 2
                        },
                        new
                        {
                            StationId = 2,
                            AffiliateId = 4
                        },
                        new
                        {
                            StationId = 3,
                            AffiliateId = 4
                        });
                });

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Composite.BroadcastTypeComposite", b =>
                {
                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.Property<int>("BroadcastTypeId")
                        .HasColumnType("int");

                    b.HasKey("StationId", "BroadcastTypeId");

                    b.ToTable("BroadcastTypeComposites");

                    b.HasData(
                        new
                        {
                            StationId = 1,
                            BroadcastTypeId = 2
                        },
                        new
                        {
                            StationId = 1,
                            BroadcastTypeId = 3
                        },
                        new
                        {
                            StationId = 2,
                            BroadcastTypeId = 2
                        },
                        new
                        {
                            StationId = 3,
                            BroadcastTypeId = 1
                        });
                });

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Composite.MarketComposite", b =>
                {
                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.Property<int>("MarketId")
                        .HasColumnType("int");

                    b.HasKey("StationId", "MarketId");

                    b.ToTable("MarketComposites");

                    b.HasData(
                        new
                        {
                            StationId = 1,
                            MarketId = 2
                        },
                        new
                        {
                            StationId = 1,
                            MarketId = 3
                        },
                        new
                        {
                            StationId = 2,
                            MarketId = 1
                        },
                        new
                        {
                            StationId = 2,
                            MarketId = 2
                        },
                        new
                        {
                            StationId = 2,
                            MarketId = 3
                        },
                        new
                        {
                            StationId = 3,
                            MarketId = 3
                        });
                });

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Composite.UserComposite", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "StationId");

                    b.ToTable("UserComposites");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            StationId = 1
                        },
                        new
                        {
                            UserId = 1,
                            StationId = 2
                        },
                        new
                        {
                            UserId = 1,
                            StationId = 3
                        },
                        new
                        {
                            UserId = 2,
                            StationId = 1
                        },
                        new
                        {
                            UserId = 2,
                            StationId = 3
                        },
                        new
                        {
                            UserId = 3,
                            StationId = 2
                        });
                });

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Models.Affiliate", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Affiliates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "New York City",
                            Name = "National Broadcasting Company",
                            ShortName = "NBC",
                            State = "New York"
                        },
                        new
                        {
                            Id = 2,
                            City = "Burbank",
                            Name = "American Broadcasting Company",
                            ShortName = "ABC",
                            State = "California"
                        },
                        new
                        {
                            Id = 3,
                            City = "New York City",
                            Name = "Columbia Broadcasting System",
                            ShortName = "CBS",
                            State = "New York"
                        },
                        new
                        {
                            Id = 4,
                            City = "London",
                            Name = "British Broadcasting Corporation",
                            ShortName = "BBC",
                            State = "England"
                        });
                });

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Models.BroadcastType", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BroadcastTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Radio"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Television"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Streaming"
                        });
                });

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Models.Market", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Markets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "New York",
                            State = "New York"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Los Angeles",
                            State = "California"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Las Vegas",
                            State = "Nevada"
                        });
                });

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Models.Station", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("CallLetters")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CallLetters = "KTLA",
                            Format = "Local Television",
                            Owner = "Nextar Media Group"
                        },
                        new
                        {
                            Id = 2,
                            CallLetters = "KABC",
                            Format = "Local Television",
                            Owner = "ABC Owned Television Stations"
                        },
                        new
                        {
                            Id = 3,
                            CallLetters = "KSNE",
                            Format = "Adult Contemporary",
                            Owner = "IHeartMedia"
                        });
                });

            modelBuilder.Entity("ShareBuildersProject_DataAccess.Models.User", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2022, 11, 11, 18, 29, 3, 684, DateTimeKind.Local).AddTicks(3673),
                            FirstName = "Mike",
                            LastName = "Jones"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2022, 11, 11, 18, 29, 3, 687, DateTimeKind.Local).AddTicks(1110),
                            FirstName = "Bob",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2022, 11, 11, 18, 29, 3, 687, DateTimeKind.Local).AddTicks(1135),
                            FirstName = "Sarah",
                            LastName = "Parker"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
