#pragma checksum "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "475f5976d7adcf7438771785eaa9016b17df115c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using BlazorApp;
    using BlazorApp.Shared;
    using System.Threading;
    using BlazorComponents.ChartJS;
    using BlazorComponents.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Index.cshtml"
 
    private double inicial { get; set; }
    private double mensal { get; set; }
    private double juros { get; set; }
    private int tempo { get; set; }
    double montante = 0;
    List<montanteClass> listaMontante = new List<montanteClass>();
    void Calcular()
    {
        montanteClass novoMontatne = new montanteClass();
        montante = 0;
        juros = juros / 100;
        montante = inicial + (inicial * juros);
        novoMontatne.totalmontante = montante;
        novoMontatne.juros = juros;
        novoMontatne.meses = 1;
        listaMontante.Add(novoMontatne);

        for (int i = 2; i <= tempo; i++)
        {
            montanteClass novoMontatne2 = new montanteClass();
            montante = montante + mensal + montante * juros;
            novoMontatne2.totalmontante = montante;
            novoMontatne2.juros = juros;
            novoMontatne2.meses = i;
            listaMontante.Add(novoMontatne2);

        }
    }

    class montanteClass
    {
        public double totalmontante { get; set; }
        public int meses { get; set; }
        public double juros { get; set; }

    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
