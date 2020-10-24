﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsManagementSystem.Data;

namespace SportsManagementSystem.Migrations
{
    [DbContext(typeof(SportsDbContext))]
    partial class SportsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsManagementSystem.Models.Competitor", b =>
                {
                    b.Property<int>("CompetitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactNo")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompetitorId");

                    b.ToTable("Competitors");
                });

            modelBuilder.Entity("SportsManagementSystem.Models.CompetitorGame", b =>
                {
                    b.Property<int>("CompetitorId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("CompetitorId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("CompetitorGames");
                });

            modelBuilder.Entity("SportsManagementSystem.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeatureEvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorldRecord")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.HasIndex("GameId1");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SportsManagementSystem.Models.EventOutcome", b =>
                {
                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompetitorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CompetitorId1")
                        .HasColumnType("int");

                    b.Property<int?>("EventId1")
                        .HasColumnType("int");

                    b.Property<string>("Medal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("EventId", "CompetitorId");

                    b.HasIndex("CompetitorId1");

                    b.HasIndex("EventId1");

                    b.ToTable("EventOutcomes");
                });

            modelBuilder.Entity("SportsManagementSystem.Models.EventPhoto", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventId1")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoTags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoId");

                    b.HasIndex("EventId1");

                    b.ToTable("EventPhotos");
                });

            modelBuilder.Entity("SportsManagementSystem.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationInHours")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RulesBooklet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("SportsManagementSystem.Models.CompetitorGame", b =>
                {
                    b.HasOne("SportsManagementSystem.Models.Competitor", "Competitor")
                        .WithMany()
                        .HasForeignKey("CompetitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportsManagementSystem.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportsManagementSystem.Models.Event", b =>
                {
                    b.HasOne("SportsManagementSystem.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportsManagementSystem.Models.EventOutcome", b =>
                {
                    b.HasOne("SportsManagementSystem.Models.Competitor", "Competitor")
                        .WithMany()
                        .HasForeignKey("CompetitorId1");

                    b.HasOne("SportsManagementSystem.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId1");
                });

            modelBuilder.Entity("SportsManagementSystem.Models.EventPhoto", b =>
                {
                    b.HasOne("SportsManagementSystem.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId1");
                });
#pragma warning restore 612, 618
        }
    }
}
