#pragma checksum "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad50496960dbe6fc2c7c2cebc55be379ae8eb408"
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
#line 1 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public partial class ListProductsWareHouseComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p><a href=\"wherehouse/addproducts\">Agregar Producto a Bodega</a></p>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<label for=\"wherehouse\">Filtrar por bodega: </label>\r\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "id", "wherehouse");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                                       WherehouseChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "form-control");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value");
            __builder.AddContent(10, "Seleccionar bodega ...");
            __builder.CloseElement();
#nullable restore
#line 13 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
         foreach (var wherehouse in wherehouses)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 15 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                            wherehouse.WareHouseId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, 
#nullable restore
#line 15 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                                                     wherehouse.WareHouseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n<hr>\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "h3 text-center");
            __builder.AddContent(17, 
#nullable restore
#line 21 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
     warehouseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<hr>\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n    Total productos registradas: ");
            __builder.AddContent(21, 
#nullable restore
#line 25 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                                  storageTemp.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<hr>");
#nullable restore
#line 28 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
 if (storageTemp == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p><em>Cargando...</em></p>");
#nullable restore
#line 31 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "id", "productsTable");
            __builder.AddAttribute(26, "class", "display table table-bordered table-hover");
            __builder.AddMarkupContent(27, "<thead><tr><th>Referencia</th>\r\n                <th>Producto</th>\r\n                <th>Bodega</th>\r\n                <th>Cantidad</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 46 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
             foreach (var storage in storageTemp)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 49 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                         storage.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 50 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                         storage.Product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 52 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                         storage.PartialQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 53 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                         storage.WareHouses.WareHouseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "storage/update/" + (
#nullable restore
#line 55 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
                                                 storage.StorageId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\WareHouse\ListProductsWareHouseComponent.razor"
       
    private List<WareHouseEntity> wherehouses = new List<WareHouseEntity>();
    private List<StorageEntity> storages = new List<StorageEntity>();
    private List<StorageEntity> storageTemp = new List<StorageEntity>();

    private string warehouseName;

    protected override async Task OnInitializedAsync()
    {
        wherehouses = B_Warehouse.WareHouseList();
        storages = B_Storage.StoragesList();

        storageTemp = storages;
    }

    private void WherehouseChanged(ChangeEventArgs e)
    {
        var warehouseId = e.Value.ToString();

        if (string.IsNullOrEmpty(warehouseId))
        {
            storageTemp = storages;
            warehouseName = "";
        }
        else
        {
            storageTemp = storages.Where(st => st.WareHouseId == warehouseId).ToList();
            warehouseName = storageTemp.LastOrDefault().WareHouses.WareHouseName;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591