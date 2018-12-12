#pragma checksum "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Lembretes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1433a75766b792823c3bb3ac8215a4217e530981"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/Lembretes")]
    public class Lembretes : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 45 "C:\Users\Marcio\Desktop\blazor-teste\BlazorApp\BlazorApp\Pages\Lembretes.cshtml"
 
        public string Nome { get; set; }
        public DateTime data { get; set; }
        public DateTime dating = DateTime.Now;
        List<lembrete> listaLembrete = new List<lembrete>();
        public string notification { get; set; }


        void Salvar()
        {
            lembrete novoLembrete = new lembrete();
            novoLembrete.nome = Nome;
            novoLembrete.datas = data;
            listaLembrete.Add(novoLembrete);
            List<MyEvent> _myEvents;
            _myEvents = new List<MyEvent>()
{
    new MyEvent("My event A", DateTime.Now.AddSeconds(5)),
    new MyEvent("My event B", DateTime.Now.AddSeconds(10)),
    new MyEvent("My event C", DateTime.Now.AddSeconds(20))
};

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    // Report events' status
                    DateTime now = DateTime.Now;

                    foreach (var myEvent in _myEvents.Where(e => e.Time <= now))
                        System.Diagnostics.Debug.WriteLine(string.Format("Event '{0}' already held", myEvent.Name));

                    foreach (var myEvent in _myEvents.Where(e => e.Time > now))
                    {
                        string notification = "Event '{0}' at '{1}' starting in {2} seconds";
                        TimeSpan timeSpan = myEvent.Time - now;
                        notification = string.Format(notification, myEvent.Name, myEvent.Time, (int)timeSpan.TotalSeconds);
                        
                    }
                   
                
                // Wait for a while before next iteration
                Thread.Sleep(8000);
                }
            });
    }

    class lembrete
    {
        public string nome { get; set; }
        public DateTime datas { get; set; }

    }

    class MyEvent
    {
        public MyEvent()
        { }

        public MyEvent(string name, DateTime time)
        {
            Name = name;
            Time = time;
        }

        public string Name { get; set; }

        public DateTime Time { get; set; }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591