#pragma checksum "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf1c07e19d406ba12d202897d673fcf143260f39"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.Layout>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Header>(4);
                    __builder3.AddAttribute(5, "Class", "header");
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(7, "<div class=\"logo\" b-1cyqms2v47></div>\r\n                ");
                        __builder4.OpenComponent<AntDesign.Menu>(8);
                        __builder4.AddAttribute(9, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuTheme>(
#nullable restore
#line 7 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Shared\MainLayout.razor"
                             MenuTheme.Dark

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(10, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 7 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Shared\MainLayout.razor"
                                                   MenuMode.Horizontal

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(11, "DefaultSelectedKeys", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 7 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Shared\MainLayout.razor"
                                                                                              new []{"1"}

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.MenuItem>(13);
                            __builder5.AddAttribute(14, "Key", "1");
                            __builder5.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(16, "Today");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(17, "\r\n                    ");
                            __builder5.OpenComponent<AntDesign.MenuItem>(18);
                            __builder5.AddAttribute(19, "Key", "2");
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(21, "Calendar");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(22, "\r\n\r\n                    ");
                            __builder5.OpenComponent<DemoHabitTracker.Shared.LoginDisplay>(23);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.Content>(25);
                    __builder3.AddAttribute(26, "Style", "padding: 0 50px");
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(28, 
#nullable restore
#line 16 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.Footer>(30);
                    __builder3.AddAttribute(31, "Style", "text-align: center; ");
                    __builder3.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(33, "Ant Design ©2018 Created by Ant UED");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(34, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "<p b-1cyqms2v47>Please sign in.</p> //Qui ci andranno i componenti che espongono i contenuti del sito, la pagina di presntazione\r\n        ");
                __builder2.OpenComponent<DemoHabitTracker.Shared.LoginDisplay>(36);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\hp\source\repos\ElaboratoEsame\DemoHabitTracker\DemoHabitTracker\Shared\MainLayout.razor"
 
                private void OnPanelChange(DateTime value, string mode)
                {
                    Console.WriteLine($"{value.ToString("YYYY-MM-DD")} {mode}");
                }
            

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
