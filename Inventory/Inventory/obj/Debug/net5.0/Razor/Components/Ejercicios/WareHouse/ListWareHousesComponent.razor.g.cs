#pragma checksum "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8885a8c908893b44963ce0cc38dbaad666b1317b"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Ejercicios.WareHouse
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.WareHouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public partial class ListWareHousesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p><a href=\"wherehouse/create\">Agregar Nueva Bodega</a></p>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    Total bodegas registradas: ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
                                warehouses.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<hr>");
#nullable restore
#line 12 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
 if (warehouses == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Cargando...</em></p>");
#nullable restore
#line 15 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "display table table-bordered table-hover");
            __builder.AddMarkupContent(8, "<thead><tr><th>Bodega</th>\r\n                <th>Dirección</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 27 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
             foreach (var warehouse in warehouses)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
                         warehouse.WareHouseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
                         warehouse.WareHouseAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "wherehouse/update/" + (
#nullable restore
#line 33 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
                                                    warehouse.WareHouseId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListWareHousesComponent.razor"
       
    [Parameter]
    public string ToPage { get; set; }

    private List<WareHouseEntity> warehouses = new List<WareHouseEntity>();

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.WareHouseList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591