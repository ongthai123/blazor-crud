#pragma checksum "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ecd30e2c10a7ef86925a83cbc44da8bd4e2f600"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CRUD_Blazor.Pages.Category
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
#line 3 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Edit.razor"
using CRUD_Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/edit/{Id}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Edit.razor"
       
    [Parameter]
    public string Id { get; set; }

    Category category = new Category();

    protected override async Task OnInitializedAsync()
    {
        category = await Task.Run(() => categorySerivce.GetCategoryById(Convert.ToInt32(Id)));
    }

    public void UpdateCategory()
    {
        categorySerivce.Update(category);
        //navigationManager.NavigateTo("category");
    }

    void Cancel()
    {
        navigationManager.NavigateTo("category");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CategoryService categorySerivce { get; set; }
    }
}
#pragma warning restore 1591
