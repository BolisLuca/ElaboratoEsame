using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(DemoHabitTracker.Areas.Identity.IdentityHostingStartup))]
namespace DemoHabitTracker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}