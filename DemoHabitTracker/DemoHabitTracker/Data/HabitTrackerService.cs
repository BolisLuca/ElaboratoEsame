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

        public async Task<List<Habit>> GetAllUserHabits(string username)
        {
            return await _context.Habits.Where(i => i.fkUserName == username).ToListAsync();
        }
        public List<HabitOccasion> GetAllTodaysUserHabits(string username)
        {
            var data = _context.Habits.Where(i => i.fkUserName == username)
        .Join(
            _context.Occasions,
            habit => habit.HabitId,
            occasion => occasion.HabitId,
            (habit, occasion) => new HabitOccasion()
            {
                HabitId = habit.HabitId,
                Title = habit.Title,
                Description = habit.Description,
                RepeatValue = habit.RepeatValue,
                RequiredTomatoes = habit.RequiredTomatoes,
                fkUserName = habit.fkUserName,
                OccasionId = occasion.OccasionId,
                ScheduledDate = occasion.ScheduledDate,
                Status = occasion.Status
            }
        ).Where(i => i.ScheduledDate == DateTime.Today).ToList();

            return data;
        }

        public List<HabitOccasion> GetAllUserOccasions(string username)
        {
            var data = _context.Habits.Where(i => i.fkUserName == username)
        .Join(
            _context.Occasions,
            habit => habit.HabitId,
            occasion => occasion.HabitId,
            (habit, occasion) => new HabitOccasion()
            {
                HabitId = habit.HabitId,
                Title = habit.Title,
                Description = habit.Description,
                RepeatValue = habit.RepeatValue,
                RequiredTomatoes = habit.RequiredTomatoes,
                fkUserName = habit.fkUserName,
                OccasionId = occasion.OccasionId,
                ScheduledDate = occasion.ScheduledDate,
                Status = occasion.Status
            }
        ).ToList();

            return data;
        }
        public async Task<bool> AddHabitAsync(Habit habit, DateTime startingdate)
        {
            await _context.Habits.AddAsync(habit);
            await _context.SaveChangesAsync();


            switch (habit.RepeatValue)
            {
                case HabitRepeatValue.Never:
                    Occasion occasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate };
                    await _context.AddAsync(occasion);
                    break;
                case HabitRepeatValue.Daily:
                    List<Occasion> Dailyoccasions = new List<Occasion>();
                    for (int i = 0; i < 1000; i++)
                    {
                        if (i == 0)
                        {
                            Occasion Dailyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate };
                            Dailyoccasions.Add(Dailyoccasion);
                        }
                        else
                        {
                            Occasion Dailyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate.AddDays(i) };
                            Dailyoccasions.Add(Dailyoccasion);
                        }

                    }

                    await _context.AddRangeAsync(Dailyoccasions);
                    break;
                case HabitRepeatValue.Weekly:
                    List<Occasion> Weeklyoccasions = new List<Occasion>();
                    for (int i = 0; i < 143; i++)
                    {
                        if (i == 0)
                        {
                            Occasion Weeklyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate };
                            Weeklyoccasions.Add(Weeklyoccasion);
                        }
                        else
                        {
                            Occasion Weeklyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate.AddDays(i * 7) };
                            Weeklyoccasions.Add(Weeklyoccasion);
                        }

                    }
                    await _context.AddRangeAsync(Weeklyoccasions);
                    break;
                case HabitRepeatValue.Monthly:
                    List<Occasion> Monthlyoccasions = new List<Occasion>();
                    for (int i = 0; i < 32; i++)
                    {
                        if (i == 0)
                        {
                            Occasion Monthlyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate };
                            Monthlyoccasions.Add(Monthlyoccasion);
                        }
                        else
                        {
                            Occasion Weeklyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate.AddMonths(i) };
                            Monthlyoccasions.Add(Weeklyoccasion);
                        }

                    }
                    await _context.AddRangeAsync(Monthlyoccasions);
                    break;

            }

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Habit> GetHabitAsync(int id)
        {
            Habit habit = await _context.Habits.FirstOrDefaultAsync(i => i.HabitId == id);
            return habit;
        }
        public async Task<List<Occasion>> GetAllHabitOccasionsAsync(Habit habit)
        {
            var occasions = await _context.Occasions.Where(i => i.HabitId == habit.HabitId).ToListAsync();
            return occasions;
        }

        public async Task<bool> UpdateHabitAsync(Habit habit)
        {
            try
            {
                _context.Update(habit);
            }
            catch (Exception)
            {
                await AddHabitAsync(habit, DateTime.Today);
            }
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateHabitOccasionsAsync(Habit habit, DateTime startingdate)
        {
            var occasions = await RemoveFutureHabitOccasions(habit);
            switch (habit.RepeatValue)
            {
                case HabitRepeatValue.Never:
                    break;
                case HabitRepeatValue.Daily:
                    List<Occasion> Dailyoccasions = new List<Occasion>();
                    for (int i = 1; i < 1000; i++)
                    {
                        Occasion Dailyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate.AddDays(i) };
                        Dailyoccasions.Add(Dailyoccasion);


                    }

                    await _context.AddRangeAsync(Dailyoccasions);
                    break;
                case HabitRepeatValue.Weekly:
                    List<Occasion> Weeklyoccasions = new List<Occasion>();
                    for (int i = 1; i < 143; i++)
                    {
                        Occasion Weeklyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate.AddDays(i * 7) };
                        Weeklyoccasions.Add(Weeklyoccasion);
                    }
                    await _context.AddRangeAsync(Weeklyoccasions);
                    break;
                case HabitRepeatValue.Monthly:
                    List<Occasion> Monthlyoccasions = new List<Occasion>();
                    for (int i = 1; i < 32; i++)
                    {
                        Occasion Weeklyoccasion = new Occasion() { HabitId = habit.HabitId, Status = ActivityStatus.Todo, ScheduledDate = startingdate.AddMonths(i) };
                        Monthlyoccasions.Add(Weeklyoccasion);
                    }
                    await _context.AddRangeAsync(Monthlyoccasions);
                    break;

            }

            _context.Update(habit);

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOccasionStatus(HabitOccasion habitOccasion, ActivityStatus newstatus)
        {
            Occasion occasion = await _context.Occasions.FirstOrDefaultAsync(i => i.OccasionId == habitOccasion.OccasionId);
            occasion.Status = newstatus;
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> RemoveFutureHabitOccasions(Habit habit)
        {
            var occasions = await _context.Occasions.Where(i => i.HabitId == habit.HabitId).Where(i => i.ScheduledDate > DateTime.Today).ToListAsync();
            _context.RemoveRange(occasions);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> RemoveAllHabitOccasions(Habit habit)
        {
            var occasions = await _context.Occasions.Where(i => i.HabitId == habit.HabitId).ToListAsync();
            _context.RemoveRange(occasions);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteHabitAsync(Habit habit)
        {
            _context.Habits.Remove(habit);
            await RemoveAllHabitOccasions(habit);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
