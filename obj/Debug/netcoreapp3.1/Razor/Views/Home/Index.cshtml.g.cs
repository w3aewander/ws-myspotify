#pragma checksum "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eece1cb2a90a3597b9874f11406948eadcb34b52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/administrador/projetos/CSHARP/MvcApp/Views/_ViewImports.cshtml"
using MvcApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/administrador/projetos/CSHARP/MvcApp/Views/_ViewImports.cshtml"
using MvcApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eece1cb2a90a3597b9874f11406948eadcb34b52", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df07ef8027e49ca862b2c679628b74db7e0ce96", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
  
    //ViewData["Title"] = "Home Page";
    //var musicas = ViewData["musicas"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">SPOTIFY</h1>\r\n    <p>\r\n      <h1>Minhas músicas</h1>\r\n     \r\n      <ul class=\"list-group\">\r\n");
#nullable restore
#line 13 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
        foreach(var m in ViewBag.musicas ){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">\r\n                \r\n                <div class=\"row text-left\">\r\n                \r\n                <div class=\"col-3\">\r\n                    \r\n                      <img src=\"/img/speaker.png\"");
            BeginWriteAttribute("alt", " alt=\"", 514, "\"", 520, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\">\r\n                    \r\n                </div>\r\n\r\n                <div class=\"col-9\" >\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 656, "\"", 664, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                       Gênero: ");
#nullable restore
#line 26 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
                          Write(m.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 764, "\"", 772, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                       Album: ");
#nullable restore
#line 29 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
                         Write(m.Album);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 868, "\"", 876, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                       Artista: ");
#nullable restore
#line 32 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
                           Write(m.Artista);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 976, "\"", 984, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      Titulo: ");
#nullable restore
#line 35 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
                         Write(m.UrlStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>  \r\n\r\n                <div class=\"row d-block text-center\">\r\n                \r\n                  <div clas=\"col-12\">\r\n                    <audio controls autoplay>\r\n  \r\n                        <source");
            BeginWriteAttribute("src", " src= \"", 1279, "\"", 1332, 6);
            WriteAttributeValue("", 1286, "/musicas/Artista/", 1286, 17, true);
#nullable restore
#line 44 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 1303, m.Artista, 1303, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1313, "/", 1313, 1, true);
#nullable restore
#line 44 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 1314, m.Album, 1314, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1322, "/", 1322, 1, true);
#nullable restore
#line 44 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 1323, m.UrlStr, 1323, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""audio/mpeg"">
                            Seu navegador não suporta audio.
                    </audio>
                  </div>
          
                  <div class=""col-12"">
                       <button class=""btn btn-primary"">Gostei</button>
                       <button class=""btn btn-primary"">Não gostei</button>
                       <button class=""btn btn-primary"">Compartilhar</button>
                  </div>

                </div>

            </li>
");
#nullable restore
#line 58 "/home/administrador/projetos/CSHARP/MvcApp/Views/Home/Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </ul>\r\n    </p>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
