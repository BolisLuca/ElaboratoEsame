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
#nullable restore
#line 4 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
using Title = AntDesign.Charts.Title;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Report")]
    public partial class Report : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
      

    [CascadingParameter(Name = "Userhabits")] List<Habit> habits { get; set; }
    string username;
    List<HabitOccasion> AllHabitOccasions;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        username = authState.User.Identity.Name;
        habits = await habitTrackerservice.GetAllUserHabits(username);
        if (habits.Count() != 0)
        {
            AllHabitOccasions = habitTrackerservice.GetAllUserOccasions(username);
            dataRose = new List<object>();
            int i = 0;
            int others = 0;
            foreach (var habit in habits)
            {
                if (AllHabitOccasions.Where(i => i.HabitId == habit.HabitId).Count() < 10)
                {
                    others++;
                }
                else
                {
                    if (habit.RepeatValue == HabitRepeatValue.Never)
                    {
                        others++;
                    }
                    else
                    {
                        if (habit.RepeatValue == HabitRepeatValue.Weekly)
                        {
                            var obj = new { type = habit.Title, value = AllHabitOccasions.Where(i => i.HabitId == habit.HabitId).Count() * 4 };
                            dataRose.Add(obj);

                        }
                        else
                        {
                            var obj = new { type = habit.Title, value = AllHabitOccasions.Where(i => i.HabitId == habit.HabitId).Count() };
                            dataRose.Add(obj);

                        }

                    }
                }
            }

            if(others != 0)
            {
                var objothers = new { type = "Others", value = others * 50 };
                dataRose.Add(objothers);
            }
            dataDaybyDay = new List<object>();
            AllHabitOccasions.OrderBy(i => i.ScheduledDate);
            var firstday = AllHabitOccasions.Min(i => i.ScheduledDate);
            while (firstday < DateTime.Today)
            {
                var objEx = new { date = firstday.ToShortDateString(), type = "Expected", value = AllHabitOccasions.Where(i => i.ScheduledDate == firstday).Count() };
                var obj = new { date = firstday.ToShortDateString(), type = "Completed", value = AllHabitOccasions.Where(i => i.ScheduledDate == firstday).Where(i => i.Status == ActivityStatus.Done).Count() };
                dataDaybyDay.Add(obj);
                dataDaybyDay.Add(objEx);
                firstday = firstday.AddDays(1);
            }
            dataColumn = new List<object>();
            firstday = AllHabitOccasions.Min(i => i.ScheduledDate);
            while (firstday.Month < DateTime.Today.Month)
            {
                var obj = new { type = firstday.Month.ToString(), value = AllHabitOccasions.Where(i => i.ScheduledDate.Month == firstday.Month).Where(i => i.Status == ActivityStatus.Done).Count() };
                dataColumn.Add(obj);
                firstday = firstday.AddMonths(1);
            }
        }
    }


    #region Rose
    List<object> dataRose;
    List<object> dataColumn;


    readonly RoseConfig configRose = new RoseConfig
    {
        ForceFit = true,
        Title = new Title
        {
            Visible = true,
            Text = "Habits"
        },
        Description = new Description
        {
            Visible = true,
            Text =
                "Those are all your habits"
        },
        Radius = 0.8,
        RadiusField = "value",
        CategoryField = "type",
        ColorField = "type",
        Label = new RoseLabel
        {
            Visible = true,
            Type = "outer"
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                                              
        }
    };

    #endregion Rose
    List<object> dataDaybyDay;



    readonly ColumnLineConfig config2 = new ColumnLineConfig
    {
        Title = new Title
        {
            Visible = true,
            Text = "柱线混合图"
        },
        Description = new Description
        {
            Visible = true,
            Text = "自定义图形细节"
        },
        XField = "time",
        YField = new[] { "value", "count" },
        ColumnConfig = new ColumnConfig
        {
            Color = "#586bce"
        },
        LineConfig = new LineConfig
        {
            Color = "#29cae4",
            Point = new LineViewConfigPoint
            {
                Visible = true,
            },
            Label = new Label
            {
                Visible = true,
            }
        }

    };

    LineConfig configDaybyDay = new LineConfig
    {
        Title = new Title
        {
            Visible = true,
            Text = "Day by Day Analysis"
        },
        Description = new Description
        {
            Visible = true,
            Text = "You are watching the number of activities you completed every day"
        },
        Padding = "auto",
        ForceFit = true,
        XField = "date",
        YField = "value",
        YAxis = new ValueAxis
        {
            Label = new BaseAxisLabel()
        },
        Legend = new Legend
        {
            Position = "right-top"
        },
        SeriesField = "type"
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 211 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                              
    };
    ColumnConfig configColumn = new ColumnConfig
    {
        Title = new Title
        {
            Visible = true,
            Text = "Month - Activities "
        },
        Description = new Description
        {
            Visible = true,
            Text = "You are watching the number of activities that you completed each month.",
        },
        ForceFit = true,
        Padding = "auto",
        XField = "type",
        YField = "sales",
        Meta = new
        {
            Type = new
            {
                Alias = "Months"
            },
            Sales = new
            {
                Alias = "Activities"
            }
        },
        Label = new ColumnViewConfigLabel
        {
            Visible = true,
            Style = new TextStyle
            {
                FontSize = 12,
                FontWeight = 600,
                Opacity = 0.6,
            }

        }
    };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HabitTrackerService habitTrackerservice { get; set; }
    }
}
#pragma warning restore 1591
