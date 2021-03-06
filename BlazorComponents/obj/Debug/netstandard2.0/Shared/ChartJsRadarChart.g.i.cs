#pragma checksum "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorComponents\Shared\ChartJsRadarChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c72fb24c1ec1d37a1cd4020d545038eda85183c9"
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
    public class ChartJsRadarChart : ChartBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 11 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorComponents\Shared\ChartJsRadarChart.cshtml"
            

    [Parameter]
    ChartJSRadarChart Chart { get; set; }

    protected override void OnAfterRender()
    {
        ChartJSInterop.InitializeRadarChart(Chart);
    }

    public void UpdateChart(ChartJSRadarChart updatedChart)
    {
        ChartJSInterop.UpdateRadarChart(updatedChart);
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
