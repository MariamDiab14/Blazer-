#pragma checksum "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c561e3d9f7cf24a13402e9675eb485e02548fedd"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Wazem.My_Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using Project.Wazem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Blazor\day3\Project\Project.Wazem\_Imports.razor"
using Project.Wazem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
using Project.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
using Project.Wazem.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/Edit/{id:int}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductEdit</h3>");
#nullable restore
#line 9 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
 if (product != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                     product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                                             Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "<label>Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                                    product.ProducrtName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProducrtName = __value, product.ProducrtName))));
                __builder2.AddAttribute(15, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProducrtName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __Blazor.Project.Wazem.My_Component.EditProduct.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 17 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                                    ()=>product.ProducrtName

#line default
#line hidden
#nullable disable
                , 19, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddMarkupContent(22, "<label>Salary</label>\r\n            ");
                __Blazor.Project.Wazem.My_Component.EditProduct.TypeInference.CreateInputNumber_1(__builder2, 23, 24, "form-control", 25, 
#nullable restore
#line 22 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                                      product.price

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.price = __value, product.price)), 27, () => product.price);
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.Project.Wazem.My_Component.EditProduct.TypeInference.CreateValidationMessage_2(__builder2, 29, 30, 
#nullable restore
#line 23 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                                    ()=>product.price

#line default
#line hidden
#nullable disable
                , 31, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddMarkupContent(34, "<label>Category</label>\r\n            ");
                __Blazor.Project.Wazem.My_Component.EditProduct.TypeInference.CreateInputSelect_3(__builder2, 35, 36, "form-control", 37, 
#nullable restore
#line 34 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                                      product.CategoryId

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.CategoryId = __value, product.CategoryId)), 39, () => product.CategoryId, 40, (__builder3) => {
#nullable restore
#line 35 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                 foreach (var item in catList)
                   {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(41, "option");
                    __builder3.AddAttribute(42, "value", 
#nullable restore
#line 37 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                                       item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 37 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
__builder3.AddContent(43, item.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 38 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                   }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(44, "\r\n            ");
                __Blazor.Project.Wazem.My_Component.EditProduct.TypeInference.CreateValidationMessage_4(__builder2, 45, 46, 
#nullable restore
#line 40 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                                    ()=>product.CategoryId

#line default
#line hidden
#nullable disable
                , 47, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        <input type=\"submit\" value=\"Update\" class=\"btn btn-success\">\r\n        ");
                __builder2.OpenElement(49, "h3");
#nullable restore
#line 44 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
__builder2.AddContent(50, MsgErrot);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 46 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
__builder.AddContent(51, product.ProducrtName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
__builder.AddContent(52, product.price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
__builder.AddContent(53, product.CategoryId);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
                       
}else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "<h3>Employee Not Found</h3>");
#nullable restore
#line 53 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "E:\Blazor\day3\Project\Project.Wazem\My Component\EditProduct.razor"
       
    [Inject]//Service Provider
    public NavigationManager navManager { get; set; }

    public string MsgErrot { get; set; } = "";


    [Parameter]
    public int id { get; set; }

    public Product product { get; set; }

    public List<Category> catList { get; set; }
    protected override async Task OnInitializedAsync()
    {
        product = await ProService.GetByID(id);
        catList = await CatService.GetAll();
       
        await base.OnInitializedAsync();
    }
    public void Save()//model Valid
    {
        //Save Data
        MsgErrot = "";
        ProService.Update(id, product);
        Console.WriteLine(product);
            Console.WriteLine("Data Served Success");
            //REdirect Index ,Details
            //use navManager
            navManager.NavigateTo("/Product");
        }
        
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServices<Product> ProService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServices<Category> CatService { get; set; }
    }
}
namespace __Blazor.Project.Wazem.My_Component.EditProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
