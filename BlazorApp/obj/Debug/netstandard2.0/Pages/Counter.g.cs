#pragma checksum "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73e5f42ef4211ac1ff093247783429189ff95659"
// <auto-generated/>
#pragma warning disable 1591
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
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Teste</h1>\n\n\n");
            builder.OpenElement(1, "table");
            builder.AddAttribute(2, "class", "table");
            builder.AddContent(3, "\n    ");
            builder.AddMarkupContent(4, "<thead>\n        <tr>\n            <th>Nome</th>\n            <th>Idade</th>\n            <th>Hora</th>\n        </tr>\n    </thead>\n    ");
            builder.OpenElement(5, "tbody");
            builder.AddContent(6, "\n");
#line 15 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Counter.cshtml"
         foreach(var usuario in usuarios)
            {
            Console.WriteLine("teste");

#line default
#line hidden
            builder.AddContent(7, "            ");
            builder.OpenElement(8, "tr");
            builder.AddContent(9, "\n                ");
            builder.OpenElement(10, "td");
            builder.AddContent(11, usuario.Nome);
            builder.CloseElement();
            builder.AddContent(12, "\n                ");
            builder.OpenElement(13, "td");
            builder.AddContent(14, usuario.Idade);
            builder.CloseElement();
            builder.AddContent(15, "\n                ");
            builder.OpenElement(16, "td");
            builder.AddContent(17, usuario.hora);
            builder.CloseElement();
            builder.AddContent(18, "\n            ");
            builder.CloseElement();
            builder.AddContent(19, "\n");
#line 23 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Counter.cshtml"
            }

#line default
#line hidden
            builder.AddContent(20, "    ");
            builder.CloseElement();
            builder.AddContent(21, "\n");
            builder.CloseElement();
            builder.AddContent(22, "\n\n\n");
            builder.OpenElement(23, "p");
            builder.AddContent(24, "Nome Digitado: ");
            builder.AddContent(25, usuario2.Nome);
            builder.CloseElement();
            builder.AddContent(26, "\n");
            builder.OpenElement(27, "p");
            builder.AddContent(28, "Idade Digitado:");
            builder.AddContent(29, usuario2.Idade);
            builder.CloseElement();
            builder.AddContent(30, "\n");
#line 30 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Counter.cshtml"
 if (usuario2.hora == new DateTime())
{

#line default
#line hidden
            builder.AddContent(31, "    ");
            builder.AddMarkupContent(32, "<p>Hora Cadastro:</p>\n");
#line 33 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Counter.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(33, "    ");
            builder.OpenElement(34, "p");
            builder.AddContent(35, "Hora Cadastro: ");
            builder.AddContent(36, usuario2.hora);
            builder.CloseElement();
            builder.AddContent(37, "\n");
#line 37 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Counter.cshtml"
}

#line default
#line hidden
            builder.AddMarkupContent(38, "<br>\n\n");
            builder.OpenElement(39, "div");
            builder.AddContent(40, "\n    ");
            builder.OpenElement(41, "input");
            builder.AddAttribute(42, "id", "Nome");
            builder.AddAttribute(43, "type", "text");
            builder.AddAttribute(44, "placeholder", "Nome");
            builder.AddAttribute(45, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(NomeU));
            builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => NomeU = __value, NomeU));
            builder.CloseElement();
            builder.AddContent(47, "\n    ");
            builder.OpenElement(48, "input");
            builder.AddAttribute(49, "id", "Idade");
            builder.AddAttribute(50, "type", "text");
            builder.AddAttribute(51, "placeholder", "Idade");
            builder.AddAttribute(52, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(IdadeU));
            builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => IdadeU = __value, IdadeU));
            builder.CloseElement();
            builder.AddContent(54, "\n    ");
            builder.OpenElement(55, "button");
            builder.AddAttribute(56, "class", "btn btn-primary");
            builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(MostraNaTela));
            builder.AddContent(58, "Enviar");
            builder.CloseElement();
            builder.AddContent(59, "\n");
            builder.CloseElement();
            builder.AddMarkupContent(60, "\n<br>\n");
            builder.OpenElement(61, "p");
            builder.AddContent(62, "Contador: ");
            builder.AddContent(63, contador);
            builder.CloseElement();
            builder.AddContent(64, "\n");
            builder.OpenElement(65, "button");
            builder.AddAttribute(66, "class", "btn btn-primary");
            builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(IncrementaContador));
            builder.AddContent(68, "Contador");
            builder.CloseElement();
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
