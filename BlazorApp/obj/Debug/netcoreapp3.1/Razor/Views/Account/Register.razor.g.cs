#pragma checksum "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6edc336f812bdb932c908aebcbe3ab4b1dad916"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Views.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
using BLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
using ClassLibrary1.Interfaces.IServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Регистрация нового пользователя</h2>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                  RegisterViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                                    Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-4");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "p");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __Blazor.BlazorApp.Views.Account.Register.TypeInference.CreateMatTextField_0(__builder2, 13, 14, "Username", 15, 
#nullable restore
#line 12 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                                        RegisterViewModel.Name

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterViewModel.Name = __value, RegisterViewModel.Name)), 17, () => RegisterViewModel.Name);
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.BlazorApp.Views.Account.Register.TypeInference.CreateValidationMessage_1(__builder2, 19, 20, 
#nullable restore
#line 13 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                      () => RegisterViewModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "p");
                __builder2.AddMarkupContent(24, "\r\n            ");
                __Blazor.BlazorApp.Views.Account.Register.TypeInference.CreateMatTextField_2(__builder2, 25, 26, "Email", 27, 
#nullable restore
#line 16 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                                     RegisterViewModel.Email

#line default
#line hidden
#nullable disable
                , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterViewModel.Email = __value, RegisterViewModel.Email)), 29, () => RegisterViewModel.Email);
                __builder2.AddMarkupContent(30, "\r\n            ");
                __Blazor.BlazorApp.Views.Account.Register.TypeInference.CreateValidationMessage_3(__builder2, 31, 32, 
#nullable restore
#line 17 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                      () => RegisterViewModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenElement(35, "p");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __Blazor.BlazorApp.Views.Account.Register.TypeInference.CreateMatTextField_4(__builder2, 37, 38, "Password", 39, "password", 40, 
#nullable restore
#line 20 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                                        RegisterViewModel.Password

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterViewModel.Password = __value, RegisterViewModel.Password)), 42, () => RegisterViewModel.Password);
                __builder2.AddMarkupContent(43, "\r\n            ");
                __Blazor.BlazorApp.Views.Account.Register.TypeInference.CreateValidationMessage_5(__builder2, 44, 45, 
#nullable restore
#line 21 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                      () => RegisterViewModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.OpenElement(48, "p");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __Blazor.BlazorApp.Views.Account.Register.TypeInference.CreateMatTextField_6(__builder2, 50, 51, "PasswordConfirm", 52, "password", 53, 
#nullable restore
#line 24 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                                               RegisterViewModel.PasswordConfirm

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterViewModel.PasswordConfirm = __value, RegisterViewModel.PasswordConfirm)), 55, () => RegisterViewModel.PasswordConfirm);
                __builder2.AddMarkupContent(56, "\r\n            ");
                __Blazor.BlazorApp.Views.Account.Register.TypeInference.CreateValidationMessage_7(__builder2, 57, 58, 
#nullable restore
#line 25 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                      () => RegisterViewModel.PasswordConfirm

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n \r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-4");
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatButton>(65);
                __builder2.AddAttribute(66, "Type", "submit");
                __builder2.AddAttribute(67, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(69, "Register");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor"
       
    public RegisterViewModel RegisterViewModel { get; set; }
    protected override void OnInitialized()
    {
        RegisterViewModel = new RegisterViewModel();
    }
    protected void Create()
    {

        UserDTO user = new UserDTO
        {
            Name = RegisterViewModel.Name,
            Email = RegisterViewModel.Email,
            Role = "User",
            Password = RegisterViewModel.Password
        };

        var result = _userService.CreateAsync(user);
        if (result.Result.Success)
        {
            RegisterViewModel.Name = null;
            RegisterViewModel.Email = null;
            RegisterViewModel.Password = null;
            RegisterViewModel.PasswordConfirm = null;
        }
        RegisterViewModel = new RegisterViewModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
    }
}
namespace __Blazor.BlazorApp.Views.Account.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
