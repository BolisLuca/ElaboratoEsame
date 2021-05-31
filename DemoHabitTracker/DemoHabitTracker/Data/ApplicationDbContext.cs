using DemoHabitTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoHabitTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // The following configures EF to create a postgres database on heroku.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql(HabitDB.GetConnectionStringFromHerokuEnv(0));

    }
}
