#pragma checksum "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Views\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b8c34cf7f86c339ba98b0e3a9671512a05928e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Регистрация нового пользователя</h2>\r\n");
            __builder.AddMarkupContent(1, @"<form method=""post"" asp-controller=""Account"" asp-action=""Register"">
    <div asp-validation-summary=""ModelOnly""></div>
    <div>
        <label asp-for=""Name""></label><br>
        <input asp-for=""Name"">
        <span asp-validation-for=""Name""></span>
    </div>
    <div>
        <label asp-for=""Email""></label><br>
        <input asp-for=""Email"">
        <span asp-validation-for=""Email""></span>
    </div>
    <div>
        <label asp-for=""Password""></label><br>
        <input asp-for=""Password"">
        <span asp-validation-for=""Password""></span>
    </div>
    <div>
        <label asp-for=""PasswordConfirm""></label><br>
        <input asp-for=""PasswordConfirm"">
        <span asp-validation-for=""PasswordConfirm""></span>
    </div>
    <div>
        <input type=""submit"" value=""Регистрация"">
    </div>
</form>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591