#pragma checksum "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4e97be86af2b61243c25f86d4cd8211c65cb693"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages.Account
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
#line 2 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Login.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Login.razor"
using BLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Login.razor"
using ClassLibrary1.Interfaces.IServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Login.razor"
       
    public LoginViewModel LoginViewModel { get; set; }
    protected override void OnInitialized()
    {
        LoginViewModel = new LoginViewModel();
    }
    public void Loginin()
    {
        UserDTO userDTO = new UserDTO()
        {
            Email = LoginViewModel.Email,
            Password = LoginViewModel.Password
        };
        var result = _userService.SignInAsync(userDTO);
        if (result.Result.Success)
        {
            
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
    }
}
#pragma warning restore 1591
