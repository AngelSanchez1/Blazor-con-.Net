#pragma checksum "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c31bb9daa8102f999ee4c713128bb0e759f58d6"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Ejercicios.InOuts
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
#line 1 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class RegisterInOutComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "<label>Bodegas:</label>\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", "form-control");
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                            OnWarehouseChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(6, "option");
            __builder.AddContent(7, "Seleccione una bodega...");
            __builder.CloseElement();
#nullable restore
#line 8 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
         foreach (var warehouse in warehouses)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 10 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                            warehouse.WareHouseId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, 
#nullable restore
#line 10 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                                    warehouse.WareHouseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                 inout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "<label>Producto</label>\r\n        ");
                __Blazor.Inventory.Components.Ejercicios.InOuts.RegisterInOutComponent.TypeInference.CreateInputSelect_0(__builder2, 18, 19, "form-control", 20, 
#nullable restore
#line 18 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                                       inout.StorageId

#line default
#line hidden
#nullable disable
                , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => inout.StorageId = __value, inout.StorageId)), 22, () => inout.StorageId, 23, (__builder3) => {
                    __builder3.AddMarkupContent(24, "<option>Seleccione producto...</option>");
#nullable restore
#line 20 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
             foreach (var storage in storages)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(25, "option");
                    __builder3.AddAttribute(26, "value", 
#nullable restore
#line 22 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                storage.StorageId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(27, 
#nullable restore
#line 22 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                                    storage.Product.ProductName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 23 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label>Cantidad</label>\r\n        ");
                __Blazor.Inventory.Components.Ejercicios.InOuts.RegisterInOutComponent.TypeInference.CreateInputNumber_1(__builder2, 32, 33, "form-control", 34, 
#nullable restore
#line 29 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                                       inout.Quantity

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => inout.Quantity = __value, inout.Quantity)), 36, () => inout.Quantity);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "<label>Es un ingreso</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(41);
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                                         inout.IsInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => inout.IsInput = __value, inout.IsInput))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => inout.IsInput));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.OpenElement(47, "div");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "button");
                __builder2.AddAttribute(50, "value", 
#nullable restore
#line 36 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                     buttonValue

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
                                                            Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "class", "form-control btn btn-warning");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "text-center");
            __builder.AddContent(56, 
#nullable restore
#line 40 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
     message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "P:\BOT\modulo 4\unidad6\blazor\Inventory\Inventory\Components\Ejercicios\InOuts\RegisterInOutComponent.razor"
      
    InOutEntity inout = new InOutEntity();
    List<WareHouseEntity> warehouses = new List<WareHouseEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();
    ProductEntity oProduct = new ProductEntity();
    StorageEntity oStorage = new StorageEntity();

    string message;

    string buttonValue => inout.IsInput ? "Registrar Entrada" : "Registrar Salida";

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.WareHouseList();
    }

    private void OnWarehouseChanged(ChangeEventArgs e)
    {
        string id = e.Value.ToString();

        storages = B_Storage.StorageListByWarehouse(id);
    }

    private void Save()
    {
        var quantity = inout.Quantity;
        var oStorage = storages.LastOrDefault(s => s.StorageId == inout.StorageId);
        var product = oStorage.Product;

        if (!inout.IsInput)
        {
            //quantity = -1 * quantity;
            if (IsBiggerThanZero(quantity, oStorage))
            {
                oStorage.PartialQuantity = oStorage.PartialQuantity - quantity;
                B_Storage.UpdateStorage(oStorage);
                product.TotalQuantity = product.TotalQuantity - quantity;
                B_Product.UpdateProduct(product);
                message = $"No existe tal cantidad del Producto { oProduct.ProductName} ";
            }
        }
        else
        {
            oStorage.PartialQuantity = oStorage.PartialQuantity + quantity;
            B_Storage.UpdateStorage(oStorage);
            product.TotalQuantity = product.TotalQuantity + quantity;
            B_Product.UpdateProduct(product);

            message = $"El Producto { oProduct.ProductName} ha sido actualizado";
        }
    }


    private bool IsBiggerThanZero(int quantity, StorageEntity storage)
    {
        if (quantity < 0 && storage.PartialQuantity < quantity)
        {
            return false;
        }

        return true;
    }



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Inventory.Components.Ejercicios.InOuts.RegisterInOutComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
