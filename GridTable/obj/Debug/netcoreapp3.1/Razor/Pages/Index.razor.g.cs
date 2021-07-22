#pragma checksum "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5626a4c712821380908e2fe3189a25d795a9becd"
// <auto-generated/>
#pragma warning disable 1591
namespace GridTable.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/_Imports.razor"
using GridTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/_Imports.razor"
using GridTable.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/Pages/Index.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main-container");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "form");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.AddMarkupContent(5, "<label for=\"fname\">First name:</label><br>\n        <input type=\"text\" id=\"name\" value><br><br>\n        \n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "submit");
            __builder.AddAttribute(8, "value", "Submit");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/Pages/Index.razor"
                                                      HandleSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(10, "onclick", 
#nullable restore
#line 11 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/Pages/Index.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n    ");
            __builder.AddMarkupContent(13, "<div class=\"header-section\">\n        <p>Table</p>\n        <button>&#935;</button>\n    </div>\n    ");
            __builder.AddMarkupContent(14, "<div class=\"button-group\">\n        <button>Edit</button>\n        <button>Delete</button>\n        <button>Close</button>\n    </div>\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "table-container");
            __builder.AddMarkupContent(17, "\n\n        ");
            __builder.OpenElement(18, "table");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "thead");
            __builder.AddMarkupContent(21, "\n                ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\n                    <th></th>\n                    ");
            __builder.OpenElement(24, "th");
            __builder.AddContent(25, "Name");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "name-span");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/Pages/Index.razor"
                                                              HandleFilterList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<i class=\"fas fa-filter\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                    <th></th>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n            ");
            __builder.AddMarkupContent(33, "<tbody id=\"table-data\" class=\"table-data\">\n            </tbody>\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n\n    ");
            __builder.AddMarkupContent(36, "<ul class=\"filter-list\">\n\n    </ul>\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/Users/vimalraveendran/Desktop/blazor/GridTable/GridTable/Pages/Index.razor"
 
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("logUser");
        }
    }

    public async void HandleSubmit()
    {
        await JSRuntime.InvokeVoidAsync("setInputTextToTable");
        StateHasChanged();
    }
    public async void HandleFilterList()
    {
        await JSRuntime.InvokeVoidAsync("dropDownFilterList");
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
