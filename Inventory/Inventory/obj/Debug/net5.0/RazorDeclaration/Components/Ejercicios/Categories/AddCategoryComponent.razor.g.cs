// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Components.Ejercicios.Categories
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
#line 1 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Categories\AddCategoryComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Categories\AddCategoryComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class AddCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\Categories\AddCategoryComponent.razor"
       
    CategoryEntity oCategory = new CategoryEntity();

    private void Save()
    {
        B_Category.CreateCategory(oCategory);
        NavManager.NavigateTo("category/list");
    }

    private void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
