using DemoHabitTracker.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace DemoHabitTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var host = CreateHostBuilder(args).Build();


            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    SeedData.Initzialize(services).Wait();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Error seeding the DB.");
                }

            }

            MigrateDatabase(host);

            host.Run();
        }
        private static void MigrateDatabase(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            var logger = services.GetRequiredService<ILogger<Program>>();

            logger.LogInformation("MigrateDatabase");
            try
            {
                var context = services.GetRequiredService<ApplicationDbContext>();
                context.Database.Migrate();
                var contextHabit = services.GetRequiredService<HabitTrackerDbContext>();
                contextHabit.Database.Migrate();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred creating the ApplicationDB.");
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
                    var PORT = configuration.GetSection("PORT").Value;

                    if (PORT == null)
                    {
                        Console.Write("reading PORT locally.. ");
                        configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                        PORT = configuration.GetConnectionString("PORT");
                    }
                    else
                        Console.WriteLine("reading from Environment *heroku");

                    Console.WriteLine("PORT={0}", PORT);

                    int httpPort = Int32.Parse(PORT);

                    webBuilder.UseUrls("http://*:" + httpPort);

                });
    }
}
