#pragma checksum "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d87111a16ed355112c5f5e88696d05db0a12243"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdmiController_Index), @"mvc.1.0.view", @"/Views/AdmiController/Index.cshtml")]
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
#line 1 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\_ViewImports.cshtml"
using AppFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\_ViewImports.cshtml"
using AppFront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d87111a16ed355112c5f5e88696d05db0a12243", @"/Views/AdmiController/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"499d601515b3cfda8ff5ded057417a4f0556306d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdmiController_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppFront.Models.Empleo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Empleos</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Compañia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Categorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Compañia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 88 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 91 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\AdmiController\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppFront.Models.Empleo>> Html { get; private set; }
    }
}
#pragma warning restore 1591