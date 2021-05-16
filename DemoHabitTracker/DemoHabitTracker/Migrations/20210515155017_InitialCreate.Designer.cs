﻿// <auto-generated />
using System;
using DemoHabitTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoHabitTracker.Migrations
{
    [DbContext(typeof(HabitTrackerDbContext))]
    [Migration("20210515155017_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoHabitTracker.Models.Habit", b =>
                {
                    b.Property<int>("HabitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RepeatValue")
                        .HasColumnType("int");

                    b.Property<int>("RequiredTomatoes")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("fkUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HabitId");

                    b.ToTable("Habits");
                });

            modelBuilder.Entity("DemoHabitTracker.Models.Occasion", b =>
                {
                    b.Property<int>("OccasionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HabitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduledDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("OccasionId");

                    b.HasIndex("HabitId");

                    b.ToTable("Occasions");
                });

            modelBuilder.Entity("DemoHabitTracker.Models.UserScore", b =>
                {
                    b.Property<string>("fkUserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("fkUserName");

                    b.ToTable("UserScores");
                });

            modelBuilder.Entity("DemoHabitTracker.Models.Occasion", b =>
                {
                    b.HasOne("DemoHabitTracker.Models.Habit", "Habit")
                        .WithMany("Occasions")
                        .HasForeignKey("HabitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habit");
                });

            modelBuilder.Entity("DemoHabitTracker.Models.Habit", b =>
                {
                    b.Navigation("Occasions");
                });
#pragma warning restore 612, 618
        }
    }
}