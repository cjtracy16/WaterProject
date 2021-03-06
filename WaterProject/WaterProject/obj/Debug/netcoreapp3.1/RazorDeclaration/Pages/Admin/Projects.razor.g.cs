// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WaterProject.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Conner Tracy\source\repos\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Conner Tracy\source\repos\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Conner Tracy\source\repos\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Conner Tracy\source\repos\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Conner Tracy\source\repos\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Conner Tracy\source\repos\WaterProject\WaterProject\WaterProject\Pages\Admin\_Imports.razor"
using WaterProject.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/projects")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Projects : OwningComponentBase<IWaterProjectRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Conner Tracy\source\repos\WaterProject\WaterProject\WaterProject\Pages\Admin\Projects.razor"
       

    public IWaterProjectRepository repo => Service; //This line gets the data

    public IEnumerable<Project> ProjectData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        ProjectData = await repo.Projects.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/projects/details/{id}";

    public string GetEditUrl(long id) => $"/admin/projects/edit/{id}";

    public async Task RemoveProject (Project p)
    {
        repo.DeleteProject(p);
        await UpdateData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
