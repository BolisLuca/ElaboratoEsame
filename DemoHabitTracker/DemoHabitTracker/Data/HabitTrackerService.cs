using DemoHabitTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHabitTracker.Data
{
    public class HabitTrackerService
    {
        private readonly HabitTrackerDbContext _context;
        public HabitTrackerService(HabitTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<List<Activity>> GetAllUserActivities(string username)
        {
            return await _context.Activities.Where(i => i.fkUsernName == username).ToListAsync();
        }
        public async Task<List<Activity>> GetAllTodaysUserActivities(string username)
        {
            return await _context.Activities.Where(i => i.fkUsernName == username).Where(i => i.Data == DateTime.Today).ToListAsync();
        }

        public async Task<bool> AddActivityAsync(Activity activity)
        {
            await _context.Activities.AddAsync(activity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Activity> GetActivityAsync(int id)
        {
            Activity activity = await _context.Activities.FirstOrDefaultAsync(i => i.Pkid == id);
            return activity;
        }

        public async Task<bool> UpdateActivityAsync(Activity activity)
        {
            _context.Activities.Update(activity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteActivityAsync(Activity activity)
        {
            _context.Activities.Remove(activity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
