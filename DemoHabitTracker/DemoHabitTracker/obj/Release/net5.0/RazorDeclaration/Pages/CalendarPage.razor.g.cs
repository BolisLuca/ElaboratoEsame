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
#line 1 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\_Imports.razor"
using Plk.Blazor.DragDrop;

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
#line 9 "c:\users\hp\source\repos\elaboratoesame\demohabittracker\DemoHabitTracker\Pages\CalendarPage.razor"
 
    private DateTime selectedValue = new DateTime(2017, 1, 25);
    private DateTime value = new DateTime(2017, 1, 25);

    private void OnSelect(DateTime value)
    {
        this.value = value;
        selectedValue = value;
    }

    private void OnPanelChange(DateTime value, string mode)
    {
        this.value = value;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
