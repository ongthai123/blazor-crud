#pragma checksum "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d99eda07d2c0b5c9df139070b8db6edb02863fff"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
using CRUD_Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Category</h3>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
                                                                category.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category.Name = __value, category.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"MinWeight\" class=\"control-label\">MinWeight</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "form", "MinWeight");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
                                                                     category.MinWeight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category.MinWeight = __value, category.MinWeight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<label for=\"MaxWeight\" class=\"control-label\">MaxWeight</label>\r\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "form", "MaxWeight");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
                                                                     category.MaxWeight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category.MaxWeight = __value, category.MaxWeight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<label for=\"IconURL\" class=\"control-label\">IconURL</label>\r\n                ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "form", "IconURL");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "placeholder", "e.g example.com/image.jpg");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
                                                                                                           category.IconURL

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category.IconURL = __value, category.IconURL));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row");
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-md-4");
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group");
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "class", "btn btn-primary");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
                                                                        CreateCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "btn btn-primary");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 41 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
     if (result != "")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "row");
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "alert alert-danger");
            __builder.AddAttribute(86, "role", "alert");
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.AddContent(88, 
#nullable restore
#line 45 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
                 result

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 48 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\irealracing4\Desktop\CRUD_Blazor\Pages\Category\Create.razor"
       
    Category category = new Category();

    public string result { get; set; } = "";

    public void CreateCategory()
    {
        result = categorySerivce.Create(category);
        if(result == "")
        {
            navigationManager.NavigateTo("category");
        }
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
