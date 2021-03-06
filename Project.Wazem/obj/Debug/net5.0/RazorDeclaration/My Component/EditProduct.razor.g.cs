// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
