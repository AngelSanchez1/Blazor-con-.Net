#pragma checksum "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47adb90358cbd5d10be9f8a37597f29f73096d28"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Ejercicios.Products
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
#line 1 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                                        CategoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(4, "option");
            __builder.AddAttribute(5, "value", "n");
            __builder.AddContent(6, "Ver todos los productos...");
            __builder.CloseElement();
#nullable restore
#line 7 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
     foreach (var category in categories)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 9 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                        category.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, 
#nullable restore
#line 9 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                                              category.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 10 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<hr>\r\n\r\n");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(13, "<thead><tr><th>Referencia</th>\r\n            <th>Nombre producto</th>\r\n            <th>Descripcion</th>\r\n            <th>Categoria</th>\r\n            <th>Cantidad en Bodega</th></tr></thead>\r\n    ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 25 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
         foreach (var product in tmpProducts)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                 product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 29 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                 product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 30 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                 product.ProductDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 31 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                 product.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 32 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                 product.TotalQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "product/update/" + (
#nullable restore
#line 33 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
                                         product.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.AddContent(36, 
#nullable restore
#line 39 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
 message

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Products\ListProductComponent.razor"
       
    List<ProductEntity> products = new List<ProductEntity>();
    List<ProductEntity> tmpProducts = new List<ProductEntity>();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    string message;

    protected override async Task OnInitializedAsync()
    {
        products = B_Product.ProductsList();
        tmpProducts = products;
        categories = B_Category.CategoryList();
    }

    private void CategoryChanged(ChangeEventArgs e)
    {
        var id = e.Value.ToString();

        if (id != "n")
        {
            tmpProducts = products.Where(c => c.CategoryId == id).ToList();
        }
        else
        {
            tmpProducts = products;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591