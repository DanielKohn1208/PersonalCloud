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
    [Microsoft.AspNetCore.Components.RouteAttribute("/rootfiles/{Id:int}")]
    public partial class RootFiles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/home/daniel/code/PersonalCloud/Client/Pages/RootFiles.razor"
       
    [Parameter]
    public int Id{ get; set; }

    [CascadingParameter]
    public Task<AuthenticationState> authenticationState{get; set;}

    public bool IsRoot {get; set;} = false;

    protected async override Task OnInitializedAsync()
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
        await _rootFilesViewModel.GetUser(Id);
        Console.WriteLine("boutta call this ");
        await _rootFilesViewModel.GetFiles(Id);
    }

    protected async Task DeleteFile(int id)
    {

        await _rootFilesViewModel.DeleteFile(id);
        await _rootFilesViewModel.GetFiles(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRootFilesViewModel _rootFilesViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591