#pragma checksum "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73e5f42ef4211ac1ff093247783429189ff95659"
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
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 49 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Counter.cshtml"
            
    int contador = 0;
    public string NomeU { get; set; }
    public string IdadeU { get; set; }
    List<Usuario> usuarios = new List<Usuario>();
    Usuario usuario2 = new Usuario();

    void IncrementaContador()
    {
        contador++;
    }

    void MostraNaTela()
    {
        usuario2.Nome = NomeU;
        usuario2.Idade = IdadeU;
        usuario2.hora = DateTime.Now;
        Usuario usuario = new Usuario();
        usuario.Nome = NomeU;
        usuario.Idade = IdadeU;
        usuario.hora = DateTime.Now;
        usuarios.Add(usuario);

    }

    class Usuario
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public DateTime hora { get; set; }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591