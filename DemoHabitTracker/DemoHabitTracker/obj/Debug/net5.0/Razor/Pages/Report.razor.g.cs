#pragma checksum "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4797146857051f785dad0a98015103765211519a"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoHabitTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using Plk.Blazor.DragDrop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\_Imports.razor"
using DemoHabitTracker.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
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
            __builder.AddMarkupContent(0, "<h3>Report</h3>");
#nullable restore
#line 8 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
 if (habits.Count() == 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Result>(1);
            __builder.AddAttribute(2, "Status", "404");
            __builder.AddAttribute(3, "Title", "No Data");
            __builder.AddAttribute(4, "SubTitle", "Here you will be able to see your progress over time. Complete your habits and comeback tomorrow!");
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Tabs>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.TabPane>(7);
                __builder2.AddAttribute(8, "Key", "1");
                __builder2.AddAttribute(9, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "My Habits");
                }
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.DemoHabitTracker.Pages.Report.TypeInference.CreateRose_0(__builder3, 12, 13, 
#nullable restore
#line 20 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                            dataRose

#line default
#line hidden
#nullable disable
                    , 14, 
#nullable restore
#line 20 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                                              configRose

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n        ");
                __builder2.OpenComponent<AntDesign.TabPane>(16);
                __builder2.AddAttribute(17, "Key", "2");
                __builder2.AddAttribute(18, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(19, "Day by Day");
                }
                ));
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.DemoHabitTracker.Pages.Report.TypeInference.CreateAntDesign_Charts_Line_1(__builder3, 21, 22, 
#nullable restore
#line 27 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                                             dataDaybyDay

#line default
#line hidden
#nullable disable
                    , 23, 
#nullable restore
#line 27 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                                                                   configDaybyDay

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n\r\n        ");
                __builder2.OpenComponent<AntDesign.TabPane>(25);
                __builder2.AddAttribute(26, "Key", "3");
                __builder2.AddAttribute(27, "Tab", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, "Monthly");
                }
                ));
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.DemoHabitTracker.Pages.Report.TypeInference.CreateAntDesign_Charts_Column_2(__builder3, 30, 31, 
#nullable restore
#line 34 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                                               dataColumn

#line default
#line hidden
#nullable disable
                    , 32, 
#nullable restore
#line 34 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                                                                   configColumn

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
      

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
#line 144 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                                              
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
#line 211 "C:\Users\hp\Downloads\ElaboratoEsame-main (1)\ElaboratoEsame-main\DemoHabitTracker\DemoHabitTracker\Pages\Report.razor"
                              
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
namespace __Blazor.DemoHabitTracker.Pages.Report
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRose_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.RoseConfig __arg1)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Rose<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateAntDesign_Charts_Line_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.LineConfig __arg1)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Line<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateAntDesign_Charts_Column_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::AntDesign.Charts.ColumnConfig __arg1)
        {
        __builder.OpenComponent<global::AntDesign.Charts.Column<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Config", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
