#pragma checksum "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\Clases\MiAula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537a273d2ea24e3123364f4468f0f880e84137f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clases_MiAula), @"mvc.1.0.view", @"/Views/Clases/MiAula.cshtml")]
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
#line 1 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\_ViewImports.cshtml"
using AplicacionBdSqlServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\_ViewImports.cshtml"
using AplicacionBdSqlServer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537a273d2ea24e3123364f4468f0f880e84137f3", @"/Views/Clases/MiAula.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957987b0013c608e242e08a713e1a2be1c323273", @"/Views/_ViewImports.cshtml")]
    public class Views_Clases_MiAula : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537a273d2ea24e3123364f4468f0f880e84137f33321", async() => {
                WriteLiteral("\r\n    <title>Upn</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537a273d2ea24e3123364f4468f0f880e84137f34313", async() => {
                WriteLiteral(@"
    <h1>Bienvenido</h1>
    <hr />
    <button class=""btn btn-success"">
        <a href=""/clases/registrarA"">Registrar Matricula</a>
    </button>
    <div class=""container"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Alumno</th>
                    <th>Curso</th>
                    <th>Profesor</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 26 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\Clases\MiAula.cshtml"
                   int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\Clases\MiAula.cshtml"
                 foreach (var item in ViewBag.Cursos)
                {
                    i++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 31 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\Clases\MiAula.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\Clases\MiAula.cshtml"
                       Write(item.Alumnos.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\Clases\MiAula.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\Clases\MiAula.cshtml"
                       Write(item.Profesores.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "F:\ERICK\UPN\Ciclo 8\Calidad\AplicacionBdSqlServer\AplicacionBdSqlServer\Views\Clases\MiAula.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tbody>\r\n           \r\n        </table>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
