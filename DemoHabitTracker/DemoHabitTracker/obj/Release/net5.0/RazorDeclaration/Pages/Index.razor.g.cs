// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DemoHabitTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\Index.razor"
using DemoHabitTracker.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Bolis.16123\source\repos\BolisLuca\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\Index.razor"
          
        string username;
        List<Activity> UserActivities;

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            username = authState.User.Identity.Name;
            UserActivities = context.Activities.Where(i => i.fkUsernName == username).ToList();
        }

        public async Task HandleDrag()
        {

        }
        string title = "BasicModal";
        bool _visible = false;

        private void HandleOk(MouseEventArgs e)
        {
            Console.WriteLine(e);
            UserActivities.Add(new Activity() { Pkid = , })
            _visible = false;
        }

        private void HandleCancel(MouseEventArgs e)
        {
            Console.WriteLine(e);
            _visible = false;
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HabitTrackerDbContext context { get; set; }
    }
}
#pragma warning restore 1591
