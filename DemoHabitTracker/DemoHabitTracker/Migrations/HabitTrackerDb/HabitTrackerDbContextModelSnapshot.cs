// <auto-generated />
using System;
using DemoHabitTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DemoHabitTracker.Migrations.HabitTrackerDb
{
    [DbContext(typeof(HabitTrackerDbContext))]
    partial class HabitTrackerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DemoHabitTracker.Models.Habit", b =>
                {
                    b.Property<int>("HabitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("RepeatValue")
                        .HasColumnType("integer");

                    b.Property<int>("RequiredTomatoes")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("fkUserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("HabitId");

                    b.ToTable("Habits");
                });

            modelBuilder.Entity("DemoHabitTracker.Models.Occasion", b =>
                {
                    b.Property<int>("OccasionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("HabitId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ScheduledDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("OccasionId");

                    b.HasIndex("HabitId");

                    b.ToTable("Occasions");
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
