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

        // The following configures EF to create a postgres database on heroku.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql(HabitDB.GetConnectionStringFromHerokuEnv(1));
    }
}
