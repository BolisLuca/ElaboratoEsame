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
#line 1 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Plk.Blazor.DragDrop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Calendar")]
    public partial class CalendarPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
 
    string username;
    private List<HabitOccasion> UserActivities { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        username = authState.User.Identity.Name;
        UserActivities = habitTrackerservice.GetAllUserOccasions(username);
    }

    private RenderFragment DateCellRender(DateTime value)
    {
        var DailyActivities = UserActivities.Where(i => i.ScheduledDate == value).ToList();

        return

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "Template");
            __builder2.AddMarkupContent(1, "\n                   ");
            __builder2.OpenElement(2, "ul");
            __builder2.AddAttribute(3, "class", "events");
            __builder2.AddMarkupContent(4, "\n");
#nullable restore
#line 73 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                        foreach (var activity in DailyActivities)
                       {
                           if (activity.ScheduledDate <= DateTime.Today)
                           {

#line default
#line hidden
#nullable disable
            __builder2.AddContent(5, "                               ");
            __builder2.OpenElement(6, "li");
            __builder2.AddAttribute(7, "key", 
#nullable restore
#line 77 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                         activity.HabitId

#line default
#line hidden
#nullable disable
            );
            __builder2.AddMarkupContent(8, "\n");
#nullable restore
#line 78 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                    if (activity.Status == ActivityStatus.Done)
                                   {

#line default
#line hidden
#nullable disable
            __builder2.AddMarkupContent(9, "<Icon Type=\"check\" Theme=\"outline\" Style=\"color:green\"></Icon>");
#nullable restore
#line 79 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                             }
                                   else
                                   {

#line default
#line hidden
#nullable disable
            __builder2.AddMarkupContent(10, " <Icon Type=\"close\" Theme=\"outline\" Style=\"color:red\"></Icon>");
#nullable restore
#line 81 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                            }

#line default
#line hidden
#nullable disable
            __builder2.OpenElement(11, "Badge");
            __builder2.AddAttribute(12, "Text", 
#nullable restore
#line 81 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                                           activity.Title

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(13, "\n                               ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(14, "\n");
#nullable restore
#line 83 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder2.AddContent(15, "                   ");
            __builder2.OpenElement(16, "li");
            __builder2.AddAttribute(17, "key", 
#nullable restore
#line 86 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                             activity.HabitId

#line default
#line hidden
#nullable disable
            );
            __builder2.AddMarkupContent(18, "\n                       ");
            __builder2.OpenElement(19, "Badge");
            __builder2.AddAttribute(20, "Text", 
#nullable restore
#line 87 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                     activity.Title

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(21, "\n                   ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(22, "\n");
#nullable restore
#line 89 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                    }

                       }

#line default
#line hidden
#nullable disable
            __builder2.AddContent(23, "                   ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(24, "\n    ");
            __builder2.CloseElement();
        }
#nullable restore
#line 93 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
               ;
    }


    private DateTime value = DateTime.Today;
    string title = "New Habit";
    bool _ModalVisible = false;
    decimal ntomatoes;

    private void OnSelect(DateTime value)
    {
        _ModalVisible = true;
        startingdate = value;
        StateHasChanged();
    }
    DateTime startingdate;


    private void OnPanelChange(DateTime value, string mode)
    {
        this.value = value;
    }

    private async Task ModalHandleOk(MouseEventArgs e)
    {
        habit.RequiredTomatoes = int.Parse(ntomatoes.ToString());
        habit.fkUserName = username;
        await habitTrackerservice.AddHabitAsync(habit, startingdate);
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        username = authState.User.Identity.Name;
        UserActivities = habitTrackerservice.GetAllUserOccasions(username);
        habit = new Habit();

        _ModalVisible = false;
        StateHasChanged();
    }

    private void ModalHandleCancel(MouseEventArgs e)
    {
        _ModalVisible = false;

    }


    private Habit habit = new Habit();

    private void OnFinish(EditContext editContext)
    {

    }

    private void OnFinishFailed(EditContext editContext)
    {

    }

    RenderFragment<RateItemRenderContext> TomatoCharacter = (builder) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(25, "<Template>\n    O\n</Template>");
        }
#nullable restore
<<<<<<< HEAD
#line 152 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
=======
#line 153 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
>>>>>>> 82552b391a5191da4109fbaceb0a38c8d764b233
           ;



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HabitTrackerService habitTrackerservice { get; set; }
    }
}
#pragma warning restore 1591
