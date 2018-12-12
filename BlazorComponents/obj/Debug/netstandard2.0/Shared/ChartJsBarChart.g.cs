#pragma checksum "C:\Users\marcio\source\repos\BlazorApp\BlazorComponents\Shared\ChartJsBarChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1774ae6fa49126c4d1593f4ad118b7f59f652d"
// <auto-generated/>
#pragma warning disable 1591
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
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "row");
            builder.AddContent(2, "\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "container");
            builder.AddContent(5, "\n        ");
            builder.OpenElement(6, "canvas");
            builder.AddAttribute(7, "id", Chart.CanvasId);
            builder.AddAttribute(8, "width", Width);
            builder.AddAttribute(9, "height", Height);
            builder.CloseElement();
            builder.AddContent(10, "\n    ");
            builder.CloseElement();
            builder.AddContent(11, "\n");
            builder.CloseElement();
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
