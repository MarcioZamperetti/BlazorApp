#pragma checksum "C:\Users\marcio\source\repos\BlazorApp\BlazorComponents\Shared\ChartJsBarChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1774ae6fa49126c4d1593f4ad118b7f59f652d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorComponents.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using BlazorComponents.ChartJS;
    public class ChartJsBarChart : ChartBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 11 "C:\Users\marcio\source\repos\BlazorApp\BlazorComponents\Shared\ChartJsBarChart.cshtml"
            

    [Parameter]
    ChartJSBarChart Chart { get; set; }

    protected override void OnAfterRender()
    {
        ChartJSInterop.InitializeBarChart(Chart);
    }

    protected override IChart GetChart()
    {
        return Chart;
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
