#pragma checksum "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c2f836e3c25c1f77d2969441c65ae3ce6f136a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleos_IndexPost), @"mvc.1.0.view", @"/Views/Empleos/IndexPost.cshtml")]
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
#line 1 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\_ViewImports.cshtml"
using AppFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\_ViewImports.cshtml"
using AppFront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c2f836e3c25c1f77d2969441c65ae3ce6f136a", @"/Views/Empleos/IndexPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3683f5dae7471010969fd85a6c3f0f2bcb0ead2", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleos_IndexPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppFront.Models.Empleo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header class=""bg-dark"">
    <nav class=""navbar navbar-expand-lg navbar navbar-dark bg-dark"">
        <div class=""container-fluid bg-dark"">
            <a class=""navbar-brand"" href=""#"">
                <span class=""glyphicon glyphicon-briefcase""></span>¡Empleos Ya!|
            </a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
                <div class=""navbar-nav"">
                    <a class=""nav-link active""");
            BeginWriteAttribute("href", " href=\"", 874, "\"", 916, 1);
#nullable restore
#line 16 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 881, Url.Action("IndexPost", "Empleos"), 881, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Empleos</a>\r\n                    <a class=\"nav-link active\"");
            BeginWriteAttribute("href", " href=\"", 977, "\"", 1018, 1);
#nullable restore
#line 17 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 984, Url.Action("Index", "Categorias"), 984, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Categorias</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n</header>\r\n<br />\r\n<h1>Empleos</h1>\r\n\r\n<a class=\"btn btn-success text-white btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 1191, "\"", 1230, 1);
#nullable restore
#line 26 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 1198, Url.Action("Create", "Empleos"), 1198, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><span class=""glyphicon glyphicon-plus""> Postularse</span></a>

<hr />

<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/jquery.dataTables.css"">
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.23/js/jquery.dataTables.js""></script>

<table class=""table"">
    <thead>
        <tr class=""table-info"">
            <th>
                ");
#nullable restore
#line 37 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
           Write(Html.DisplayNameFor(model => model.Compañia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
           Write(Html.DisplayNameFor(model => model.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
           Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2121, "\"", 2183, 1);
#nullable restore
#line 55 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 2128, Url.Action("Details", "Empleos", new { id = item.Id }), 2128, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 56 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2284, "\"", 2346, 1);
#nullable restore
#line 60 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 2291, Url.Action("Details", "Empleos", new { id = item.Id }), 2291, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 61 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
       Write(Html.DisplayFor(modelItem => item.Compañia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2453, "\"", 2515, 1);
#nullable restore
#line 65 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 2460, Url.Action("Details", "Empleos", new { id = item.Id }), 2460, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 66 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
       Write(Html.DisplayFor(modelItem => item.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </td>\r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 2622, "\"", 2684, 1);
#nullable restore
#line 70 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 2629, Url.Action("Details", "Empleos", new { id = item.Id }), 2629, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 71 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
       Write(Html.DisplayFor(modelItem => item.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n    </td>\r\n    <td>\r\n        <a class=\"btn btn-warning text-white btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 2834, "\"", 2895, 1);
#nullable restore
#line 75 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 2841, Url.Action("Editar", "Empleos", new { id = item.Id }), 2841, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Editar<span class=\"glyphicon glyphicon-edit\"></span></a>\r\n        <a class=\"btn btn-danger text-white btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 3007, "\"", 3068, 1);
#nullable restore
#line 76 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
WriteAttributeValue("", 3014, Url.Action("Delete", "Empleos", new { id = item.Id }), 3014, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Eliminar<span class=\"glyphicon glyphicon-remove\"></span></a>\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 79 "C:\Users\dsgsdg\Desktop\ProyectoFi\AppFront\Views\Empleos\IndexPost.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
