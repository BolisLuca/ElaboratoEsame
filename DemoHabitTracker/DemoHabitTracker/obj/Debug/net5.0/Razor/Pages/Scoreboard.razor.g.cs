#pragma checksum "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f7300f8709efee1b2e8cc7670db00d62fd6591b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Scoreboard")]
    public partial class Scoreboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n<br>\r\n");
            __builder.OpenComponent<AntDesign.Row>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Col>(3);
                __builder2.AddAttribute(4, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 10 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
               18

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "<h1>Scoreboard</h1>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Col>(8);
                __builder2.AddAttribute(9, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 13 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
               6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(11, "div");
                    __builder3.OpenComponent<AntDesign.Row>(12);
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(14, "<p>Now  </p>\r\n            ");
                        __builder4.OpenComponent<AntDesign.Switch>(15);
                        __builder4.AddAttribute(16, "Checked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
                             switchValue

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 17 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
                                                    ()=> { if (switchValue) { Scores = new List<UserScore>();     } else { Scores = HabitTrackercontext.UserScores.OrderByDescending(i => i.Score).ToList(); Scores.Add(new UserScore() { fkUserName = name, Score = 3, MaxScore = 15 }); } }

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(18, "\r\n            ");
                        __builder4.AddMarkupContent(19, "<p>  Max</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenComponent<AntDesign.AntList<UserScore>>(21);
            __builder.AddAttribute(22, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<UserScore>>(
#nullable restore
#line 23 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
                     Scores

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "OnItemClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<UserScore>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<UserScore>(this, 
#nullable restore
#line 23 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
                                                            ItemClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<UserScore>)((context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.ListItem>(25);
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.ListItemMeta>(27);
                    __builder3.AddAttribute(28, "Avatar", "avatar");
                    __builder3.AddAttribute(29, "TitleTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(30, "a");
                        __builder4.AddAttribute(31, "href", "https://ng.ant.design");
                        __builder4.AddContent(32, 
#nullable restore
#line 27 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
                                                 context.fkUserName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 30 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
         if (switchValue)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(33, "div");
                    __builder3.AddContent(34, 
#nullable restore
#line 32 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
                  context.Score

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 33 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(35, "div");
                    __builder3.AddContent(36, 
#nullable restore
#line 36 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
                  context.MaxScore

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 37 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
      
            string name = "gamma@gamma.it";
            bool switchValue { get; set; }
            private List<UserScore> Scores;

            protected override async Task OnInitializedAsync()
            {
                Scores = HabitTrackercontext.UserScores.OrderByDescending(i => i.Score).ToList();
            }
            RenderFragment avatar =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<AntDesign.Avatar>(37);
            __builder2.AddAttribute(38, "Src", "https://zos.alipayobjects.com/rmsportal/ODTLcjxAfvqbxHnVXCYX.png");
            __builder2.CloseComponent();
        }
#nullable restore
#line 52 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\Scoreboard.razor"
                                                                                                                            ;



public void ItemClick(UserScore item)
{
    Console.WriteLine($"item was clicked: {item.fkUserName}");
}




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HabitTrackerDbContext HabitTrackercontext { get; set; }
    }
}
#pragma warning restore 1591
