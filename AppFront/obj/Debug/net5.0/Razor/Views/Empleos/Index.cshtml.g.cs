#pragma checksum "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe1a6fb1ee5ac5e7d6d9806d897d797f0a00375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleos_Index), @"mvc.1.0.view", @"/Views/Empleos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fe1a6fb1ee5ac5e7d6d9806d897d797f0a00375", @"/Views/Empleos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"499d601515b3cfda8ff5ded057417a4f0556306d", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppFront.Models.Empleo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fe1a6fb1ee5ac5e7d6d9806d897d797f0a003753830", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Compañia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Categorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 38 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 41 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 44 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 47 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 53 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 56 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 59 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Compañia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 62 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 65 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Posicion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 68 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ubicacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 71 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categorias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 74 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 77 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 80 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 83 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 86 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 89 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.ActionLink("Editar", "Editar", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 90 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 91 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 94 "C:\Users\josti\OneDrive\Documentos\naruto\Nueva carpeta (3)\G5-Prog-3-master\AppFront\Views\Empleos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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