// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
