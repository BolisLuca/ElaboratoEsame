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
                if (!(context.Activities.Any()))
                {


                    context.Activities.AddRange( //Attività(pkid, titolo, descrizione, stato, data, Tomato_richiesti, fkAttivitàparent, fkemailUtente) 
                        new Activity
                        {
                            Pkid = "1",
                            Title = "Studiare",
                            Description = "",
                            Status = ActivityStatus.Todo,
                            Data = DateTime.Today,
                            Tomato_richiesti = 3,
                            fkUsernName = "beta@beta.it"
                        },
                        new Activity
                        {
                            Pkid = "2",
                            Title = "Leggere",
                            Description = "Da pag. 100 a 105",
                            Status = ActivityStatus.Todo,
                            Data = DateTime.Today,
                            Tomato_richiesti = 1,
                            fkUsernName = "beta@beta.it"
                        },
                        new Activity
                        {
                            Pkid = "3",
                            Title = "Studiare",
                            Description = "",
                            Status = ActivityStatus.Todo,
                            Data = DateTime.Today,
                            Tomato_richiesti = 3,
                            fkUsernName = "alpha@alpha.it"
                        },
                        new Activity
                        {
                            Pkid = "4",
                            Title = "Tagliare il prato",
                            Description = "",
                            Status = ActivityStatus.Todo,
                            Data = DateTime.Today,
                            Tomato_richiesti = 5,
                            fkUsernName = "alpha@alpha.it"
                        }
                        );

                }
                if (!(context.UserScores.Any()))
                {
                    context.UserScores.AddRange(
                        new UserScore()
                        {
                            fkUserName = "beta@beta.it",
                            MaxScore = 10,
                            Score = 1
                        },

                        new UserScore()
                        {
                            fkUserName = "alpha@alpha.it",
                            MaxScore = 15,
                            Score = 0
                        }
                        );
                }
                context.SaveChanges();
            }
            
        }

    }
}
