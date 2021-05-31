using DemoHabitTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHabitTracker.Data
{
    public class SeedData
    {


        public static async Task Initzialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {

                //Utente 1
                var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();
                // var phonenumber = await userManager.FindByEmailAsync("ef").Result.PhoneNumber;
                var UserName = "beta@beta.it";
                var pwd = "Beta@pwd0";
                var user = await userManager.FindByNameAsync(UserName);
                if (user == null)
                {
                    user = new IdentityUser
                    {
                        UserName = UserName,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(user, pwd);
                }

                if (user == null)
                {
                    throw new Exception("Weak Password."); //fallito inserimento, unico motivo possibile è la pwd errata
                }


                //Utente2
                var UserName2 = "alpha@alpha.it";
                var pwd2 = "Alpha@pwd0";
                var user2 = await userManager.FindByNameAsync(UserName2);
                if (user2 == null)
                {
                    user2 = new IdentityUser
                    {
                        UserName = UserName,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(user2, pwd2);
                }

                if (user2 == null)
                {
                    throw new Exception("Weak Password."); //fallito inserimento, unico motivo possibile è la pwd errata
                }

            }

            using (var context = new HabitTrackerDbContext(serviceProvider.GetRequiredService<DbContextOptions<HabitTrackerDbContext>>()))
            {
                if (!context.Habits.Any())
                {

                    context.Habits.AddRange(
                        new Habit()
                        {
                            Title = "Leggere",
                            Description = "Prendi del tempo per riflettere",
                            fkUserName = "beta@beta.it",
                            RepeatValue = HabitRepeatValue.Daily,
                            RequiredTomatoes = 3,
                        },
                        new Habit()
                        {
                            Title = "Studiare",
                            Description = "Un passo alla volta",
                            fkUserName = "beta@beta.it",
                            RepeatValue = HabitRepeatValue.Daily,
                            RequiredTomatoes = 3,
                        },
                        new Habit()
                        {
                            Title = "Dormire",
                            Description = "Il sonno è la chiave della felicità",
                            fkUserName = "beta@beta.it",
                            RepeatValue = HabitRepeatValue.Daily,
                            RequiredTomatoes = 0,
                        },
                        new Habit()
                        {
                            Title = "Leggere",
                            Description = "Prendi del tempo per riflettere",
                            fkUserName = "alpha@alpha.it",
                            RepeatValue = HabitRepeatValue.Daily,
                            RequiredTomatoes = 3,
                        },
                        new Habit()
                        {
                            Title = "Studiare",
                            Description = "Un passo alla volta",
                            fkUserName = "alpha@alpha.it",
                            RepeatValue = HabitRepeatValue.Daily,
                            RequiredTomatoes = 3,
                        },
                        new Habit()
                        {
                            Title = "Dormire",
                            Description = "Il sonno è la chiave della felicità",
                            fkUserName = "alpha@alpha.it",
                            RepeatValue = HabitRepeatValue.Daily,
                            RequiredTomatoes = 0,
                        },

                        new Habit()
                        {
                            Title = "Chiama Mamma",
                            fkUserName = "alpha@alpha.it",
                            RepeatValue = HabitRepeatValue.Weekly,
                            RequiredTomatoes = 0,
                        }
                        );



                    for (int i = 0; i < 1000; i++)
                    {
                        context.Occasions.Add(new Occasion() { Status = ActivityStatus.Todo, ScheduledDate = DateTime.Today.AddDays(i), HabitId = 1 });
                    }
                    for (int i = 1000; i < 2000; i++)
                    {
                        context.Occasions.Add(new Occasion() { Status = ActivityStatus.Todo, ScheduledDate = DateTime.Today.AddDays(i), HabitId = 2 });
                    }
                    for (int i = 2000; i < 3000; i++)
                    {
                        context.Occasions.Add(new Occasion() { Status = ActivityStatus.Todo, ScheduledDate = DateTime.Today.AddDays(i), HabitId = 3 });
                    }
                    for (int i = 0; i < 100; i++)
                    {
                        context.Occasions.Add(new Occasion() { Status = ActivityStatus.Todo, ScheduledDate = DateTime.Today.AddDays(i * 7), HabitId = 7 });
                    }
                }
                await context.SaveChangesAsync();



            }

        }

    }
}
