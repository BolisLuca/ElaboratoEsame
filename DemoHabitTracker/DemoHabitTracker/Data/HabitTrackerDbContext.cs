using DemoHabitTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoHabitTracker.Data
{
    public class HabitTrackerDbContext : DbContext
    {
        public HabitTrackerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<UserScore> UserScores { get; set; }
    }
}
