#pragma checksum "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a6533c96fae252c88daf3a868cbef32781acd3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Calendar")]
    public partial class CalendarPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenComponent<AntDesign.Row>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Col>(3);
                __builder2.AddAttribute(4, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 7 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
               12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Offset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 7 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                           6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Title>(7);
                    __builder3.AddAttribute(8, "Level", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                  1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(10, "Don\'t Break The Chain!");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<AntDesign.Row>(12);
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Col>(14);
                __builder2.AddAttribute(15, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 12 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
               18

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Offset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 12 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                           3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Calendar>(18);
                    __builder3.AddAttribute(19, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 13 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                            DateTime.Today

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "DateCellRender", new System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(
#nullable restore
#line 13 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                            DateCellRender

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 13 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                    value

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "OnSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, 
#nullable restore
#line 13 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                                     OnSelect

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(23, "OnPanelChange", new System.Action<System.DateTime, System.String>(
#nullable restore
#line 13 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                                                              OnPanelChange

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddContent(24, " ");
            __builder.OpenComponent<AntDesign.Modal>(25);
            __builder.AddAttribute(26, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                      title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                 _ModalVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "OnOk", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
              ModalHandleOk

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(29, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                  ModalHandleCancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.DemoHabitTracker.Pages.CalendarPage.TypeInference.CreateForm_0(__builder2, 31, 32, 
#nullable restore
#line 21 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                  habit

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 22 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                        8

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 23 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                          16

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 24 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                 AntSizeLDSType.Default

#line default
#line hidden
#nullable disable
                , 36, (context) => (__builder3) => {
                    __builder3.OpenComponent<AntDesign.FormItem>(37);
                    __builder3.AddAttribute(38, "Label", "Title");
                    __builder3.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.DemoHabitTracker.Pages.CalendarPage.TypeInference.CreateInput_1(__builder4, 40, 41, 
#nullable restore
#line 27 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                 context.Title

#line default
#line hidden
#nullable disable
                        , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Title = __value, context.Title)), 43, () => context.Title);
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.FormItem>(45);
                    __builder3.AddAttribute(46, "Label", "Description");
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.TextArea>(48);
                        __builder4.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                    context.Description

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Description = __value, context.Description))));
                        __builder4.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => context.Description));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.FormItem>(53);
                    __builder3.AddAttribute(54, "Label", "Repeat");
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Select<HabitRepeatValue, string>>(56);
                        __builder4.AddAttribute(57, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HabitRepeatValue>(
#nullable restore
#line 34 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                    HabitRepeatValue.Daily

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "Style", "width: 120px;");
                        __builder4.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HabitRepeatValue>(
#nullable restore
#line 33 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                  context.RepeatValue

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<HabitRepeatValue>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<HabitRepeatValue>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.RepeatValue = __value, context.RepeatValue))));
                        __builder4.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<HabitRepeatValue>>>(() => context.RepeatValue));
                        __builder4.AddAttribute(62, "SelectOptions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<AntDesign.SelectOption<HabitRepeatValue, string>>(63);
                            __builder5.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HabitRepeatValue>(
#nullable restore
#line 39 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                        HabitRepeatValue.Never

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(65, "Label", "Never");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(66, "\r\n                    ");
                            __builder5.OpenComponent<AntDesign.SelectOption<HabitRepeatValue, string>>(67);
                            __builder5.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HabitRepeatValue>(
#nullable restore
#line 40 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                        HabitRepeatValue.Daily

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(69, "Label", "Daily");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(70, "\r\n                    ");
                            __builder5.OpenComponent<AntDesign.SelectOption<HabitRepeatValue, string>>(71);
                            __builder5.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HabitRepeatValue>(
#nullable restore
#line 41 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                        HabitRepeatValue.Weekly

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(73, "Label", "Weekly");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(74, "\r\n                    ");
                            __builder5.OpenComponent<AntDesign.SelectOption<HabitRepeatValue, string>>(75);
                            __builder5.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<HabitRepeatValue>(
#nullable restore
#line 42 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                        HabitRepeatValue.Monthly

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(77, "Label", "Monthly");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.FormItem>(79);
                    __builder3.AddAttribute(80, "Label", "Tomatoes");
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Rate>(82);
                        __builder4.AddAttribute(83, "Character", new Microsoft.AspNetCore.Components.RenderFragment<AntDesign.RateItemRenderContext>(
#nullable restore
#line 47 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                      TomatoCharacter

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 47 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                     3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal>(
#nullable restore
#line 47 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                               ntomatoes

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ntomatoes = __value, ntomatoes))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
            }
            ));
            __builder.CloseComponent();
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
            __builder2.OpenComponent<AntDesign.Template>(87);
            __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                __builder3.OpenElement(89, "ul");
                __builder3.AddAttribute(90, "class", "events");
#nullable restore
#line 73 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                        foreach (var activity in DailyActivities)
                       {
                           if (activity.ScheduledDate <= DateTime.Today)
                           {

#line default
#line hidden
#nullable disable
                __builder3.OpenElement(91, "li");
                __builder3.AddAttribute(92, "key", 
#nullable restore
#line 77 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                         activity.HabitId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 78 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                    if (activity.Status == ActivityStatus.Done)
                                   {

#line default
#line hidden
#nullable disable
                __builder3.OpenComponent<AntDesign.Icon>(93);
                __builder3.AddAttribute(94, "Type", "check");
                __builder3.AddAttribute(95, "Theme", "outline");
                __builder3.AddAttribute(96, "Style", "color:green");
                __builder3.CloseComponent();
#nullable restore
#line 79 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                             }
                                   else
                                   {

#line default
#line hidden
#nullable disable
                __builder3.OpenComponent<AntDesign.Icon>(97);
                __builder3.AddAttribute(98, "Type", "close");
                __builder3.AddAttribute(99, "Theme", "outline");
                __builder3.AddAttribute(100, "Style", "color:red");
                __builder3.CloseComponent();
#nullable restore
#line 81 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                            }

#line default
#line hidden
#nullable disable
                __builder3.OpenComponent<AntDesign.Badge>(101);
                __builder3.AddAttribute(102, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                                                                                           activity.Title

#line default
#line hidden
#nullable disable
                ));
                __builder3.CloseComponent();
                __builder3.CloseElement();
#nullable restore
#line 83 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder3.OpenElement(103, "li");
                __builder3.AddAttribute(104, "key", 
#nullable restore
#line 86 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                             activity.HabitId

#line default
#line hidden
#nullable disable
                );
                __builder3.OpenComponent<AntDesign.Badge>(105);
                __builder3.AddAttribute(106, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                                     activity.Title

#line default
#line hidden
#nullable disable
                ));
                __builder3.CloseComponent();
                __builder3.CloseElement();
#nullable restore
#line 89 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
                    }

                       }

#line default
#line hidden
#nullable disable
                __builder3.CloseElement();
            }
            ));
            __builder2.CloseComponent();
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
        await UpdateUserActivities();
        habit = new Habit();

        _ModalVisible = false;
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

    private async Task UpdateUserActivities()
    {
        UserActivities = habitTrackerservice.GetAllTodaysUserHabits(username);
    }
    RenderFragment<RateItemRenderContext> TomatoCharacter = (builder) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<AntDesign.Template>(107);
            __builder2.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                __builder3.AddMarkupContent(109, "\r\n    O\r\n");
            }
            ));
            __builder2.CloseComponent();
        }
#nullable restore
#line 153 "C:\Users\hp\Source\Repos\ElaboratoEsame2\DemoHabitTracker\DemoHabitTracker\Pages\CalendarPage.razor"
           ;



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HabitTrackerService habitTrackerservice { get; set; }
    }
}
namespace __Blazor.DemoHabitTracker.Pages.CalendarPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateForm_0<TModel>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TModel __arg0, int __seq1, global::OneOf.OneOf<global::System.String, global::System.Int32> __arg1, int __seq2, global::OneOf.OneOf<global::System.String, global::System.Int32> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TModel> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Form<TModel>>(seq);
        __builder.AddAttribute(__seq0, "Model", __arg0);
        __builder.AddAttribute(__seq1, "LabelColSpan", __arg1);
        __builder.AddAttribute(__seq2, "WrapperColSpan", __arg2);
        __builder.AddAttribute(__seq3, "Size", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
