using Google.Apis.Auth.AspNetCore3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace WebApplication7.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IGoogleAuthProvider _auth;
        public static string[] Scopes = { CalendarService.Scope.CalendarEvents };
        public static string ApplicationName = "Google Calendar API .NET Quickstart";

        public readonly List<Event> events1;
        public IndexModel(ILogger<IndexModel> logger, IGoogleAuthProvider auth)
        {
            _logger = logger;
            _auth = auth;
        }

        
        public async System.Threading.Tasks.Task OnGetAsync()
        {
            
            GoogleCredential cred = await _auth.GetCredentialAsync();

            CalendarService Service = new CalendarService(new BaseClientService.Initializer() { HttpClientInitializer = cred, ApplicationName = ApplicationName });
            EventsResource.ListRequest request = Service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.MaxResults = 2500;
            Events events = request.Execute();

            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (Event eventItem in events.Items)
                {
                    if (eventItem.Start == null && eventItem.Status == "cancelled")
                    {
                        events1.Add(eventItem);
                    }
                }
            }
        }
    }
}
