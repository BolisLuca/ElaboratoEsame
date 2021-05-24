// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DemoHabitTracker.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Plk.Blazor.DragDrop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Data;

#line default
#line hidden
#nullable disable
    public partial class LoadingScreen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Shared\LoadingScreen.razor"
       
    bool isLoaded;
    public List<HabitOccasion> UserActivities = new List<HabitOccasion>();
    public List<HabitOccasion> UserActivitiesKanbanShowing; 
    public List<Habit> Userhabits;


    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override async Task OnInitializedAsync() //HabitId Title  Description RepeatValue RequiredTomatoes fkUserName OccasionId ScheduledDate Status 
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var username = authState.User.Identity.Name;
        UserActivities =  habitTrackerservice.GetAllTodaysUserHabits(username);
        UserActivitiesKanbanShowing = new List<HabitOccasion>(UserActivities);
        UserActivitiesKanbanShowing.Add(new HabitOccasion() { HabitId = 0, Status = ActivityStatus.Todo, Description = UserActivities.Where(i => i.Status == ActivityStatus.Todo).Count() + "/" + UserActivities.Count() });
        UserActivitiesKanbanShowing.Add(new HabitOccasion() { HabitId = 0, Status = ActivityStatus.Doing, Description = UserActivities.Where(i => i.Status == ActivityStatus.Doing).Count() + "/" + UserActivities.Count() });
        UserActivitiesKanbanShowing.Add(new HabitOccasion() { HabitId = 0, Status = ActivityStatus.Done, Description = UserActivities.Where(i => i.Status == ActivityStatus.Done).Count() + "/" + UserActivities.Count() });
        Userhabits = await habitTrackerservice.GetAllUserHabits(username);
        isLoaded = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HabitTrackerService habitTrackerservice { get; set; }
    }
}
#pragma warning restore 1591
