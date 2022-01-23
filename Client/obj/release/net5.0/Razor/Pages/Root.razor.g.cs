#pragma checksum "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d157f95961afe2bed32609749f0c3bc9ba6bc0f4"
// <auto-generated/>
#pragma warning disable 1591
namespace PersonalCloud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using PersonalCloud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using PersonalCloud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using PersonalCloud.Client.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/daniel/code/PersonalCloud/Client/_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/root")]
    public partial class Root : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
 if(IsRoot)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h2><b>Root Controls</b></h2>");
            __builder.AddMarkupContent(1, "<h3>Add User</h3>\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "mb-3");
            __builder.AddMarkupContent(4, "<label for=\"inputUsername\" class=\"form-label\">Username</label> \n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "id", "inputUsername");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "placeholder", "Username");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
                                                      _rootViewModel.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _rootViewModel.Username = __value, _rootViewModel.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "class", "text-danger");
#nullable restore
#line 13 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
__builder.AddContent(15, UsernameValidation);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "mb-3");
            __builder.AddMarkupContent(18, "<label for=\"inputPassword\" class=\"form-label\">Password</label> \n        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "id", "inputPassword");
            __builder.AddAttribute(21, "type", "password");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "Password");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
                                                          _rootViewModel.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _rootViewModel.Password = __value, _rootViewModel.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "text-danger");
#nullable restore
#line 19 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
__builder.AddContent(29, PasswordValidation);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "mb-3");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-outline-dark");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
                                                       CreateUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Add User");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n    ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "class", "text-danger");
#nullable restore
#line 26 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
__builder.AddContent(39, ServerValidation);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "<h3>Users</h3>\n    ");
            __builder.OpenElement(41, "table");
            __builder.AddAttribute(42, "class", "table");
            __builder.AddMarkupContent(43, "<tr><td scope=\"col\">Username</td>\n            <td scope=\"col\">View Files</td>\n            <td scope=\"col\">Delete</td></tr>");
#nullable restore
#line 35 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
         foreach(var user in @_rootViewModel.Users)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "tr");
            __builder.OpenElement(45, "td");
#nullable restore
#line 38 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
__builder.AddContent(46, user.UserName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "class", "btn btn-outline-dark");
            __builder.AddAttribute(51, "href", 
#nullable restore
#line 40 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
                                                           $"https://localhost:5001/rootfiles/{user.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, "View Files");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n                ");
            __builder.OpenElement(54, "td");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-outline-danger");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
                                                                     () => DeleteUser(user.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Delete User");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 48 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "<p>You are not authorized to view ths page</p>");
#nullable restore
#line 52 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/home/daniel/code/PersonalCloud/Client/Pages/Root.razor"
       
    //error messages
    public string UsernameValidation{get; set;}
    public string PasswordValidation{get; set;}
    public string ServerValidation{get; set;}

    [CascadingParameter]
    public Task<AuthenticationState> authenticationState{get; set;}
    
    public bool IsRoot{ get; set;} = false;

    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationState;
        if(!authState.User.Identity.IsAuthenticated)
        {
            _navigationManager.NavigateTo("/");
            return;
        }
        if(!authState.User.IsInRole("root"))
        {
            return;
        }
        IsRoot = true;
        await _rootViewModel.GetUsers();
    }

    protected async Task CreateUser()
    {
        PasswordValidation = String.Empty;
        UsernameValidation = String.Empty;
        if(_rootViewModel.Username.Length>16 || _rootViewModel.Username==String.Empty)
        {
            UsernameValidation = "The username chosen must be between 0 and 16 characters";
            if(_rootViewModel.Password.Length>16 ||_rootViewModel.Password==String.Empty)
            {
                PasswordValidation = "The password chosen must be between 0 and 16 characters long";
            }
            return;
        }
        if(_rootViewModel.Password.Length>16 || _rootViewModel.Password==String.Empty)
        {
            PasswordValidation = "The password chosen must be between 0 and 16 characters long";
            return;
        }
        var response = await _rootViewModel.CreateUser();
        if(!response.IsSuccessStatusCode)
        { 
            ServerValidation = await response.Content.ReadAsStringAsync();
            return; 
        }
        Console.WriteLine("thins would appear to be working");
        await _rootViewModel.GetUsers();
        
    }

    protected async Task DeleteUser(long id)
    {
        await _rootViewModel.DeleteUser(id);
        await _rootViewModel.GetUsers();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRootViewModel _rootViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591