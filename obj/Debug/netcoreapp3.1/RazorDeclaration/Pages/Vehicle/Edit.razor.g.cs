#pragma checksum "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Vehicle\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6279463275ffa187ec09eef86fb8404bec99cb94"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CRUD_Blazor.Pages.Vehicle
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using CRUD_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\irealracing4\Desktop\CRUD_Blazor\_Imports.razor"
using CRUD_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Vehicle\Edit.razor"
using CRUD_Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vehicle/edit/{Id}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Vehicle\Edit.razor"
       
    [Parameter]
    public string Id { get; set; }

    Vehicle vehicle = new Vehicle();

    public string result { get; set; } = "";

    protected override async Task OnInitializedAsync()
    {
        vehicle = await Task.Run(() => vehicleSerivce.GetVehicleById(Convert.ToInt32(Id)));
    }

    public void UpdateVehicle()
    {
        result = vehicleSerivce.Update(vehicle);
        if (result == "")
        {
            navigationManager.NavigateTo("vehicle");
        }
    }

    void Cancel()
    {
        navigationManager.NavigateTo("vehicle");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VehicleService vehicleSerivce { get; set; }
    }
}
#pragma warning restore 1591