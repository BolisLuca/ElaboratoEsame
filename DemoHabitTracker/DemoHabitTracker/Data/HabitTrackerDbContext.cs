using DemoHabitTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoHabitTracker.Data
{
    public class HabitTrackerDbContext : DbContext
    {
        public HabitTrackerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Occasion> Occasions { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<UserScore> UserScores { get; set; }
    }
}
