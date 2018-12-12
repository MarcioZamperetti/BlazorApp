#pragma checksum "C:\Users\marcio\source\repos\BlazorApp\BlazorComponents\Shared\ChartJsPieChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea3efef75d6abb9f9816f27f73c199a831157c5c"
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
    public class ChartJsPieChart : ChartBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 12 "C:\Users\marcio\source\repos\BlazorApp\BlazorComponents\Shared\ChartJsPieChart.cshtml"
            

    [Parameter]
    ChartJSPieChart Chart { get; set; }

    protected override void OnAfterRender()
    {
        ChartJSInterop.InitializePieChart(Chart);
    }

    public void UpdateChart(ChartJSPieChart updatedChart)
    {
        ChartJSInterop.UpdatePieChart(updatedChart);
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
