#pragma checksum "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e25886c686a1399819863d8698697f01f34b721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zivotinje_izgubljeneDetaljiSkloniste), @"mvc.1.0.view", @"/Views/Zivotinje/izgubljeneDetaljiSkloniste.cshtml")]
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
#line 1 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\_ViewImports.cshtml"
using PIS_projekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\_ViewImports.cshtml"
using PIS_projekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e25886c686a1399819863d8698697f01f34b721", @"/Views/Zivotinje/izgubljeneDetaljiSkloniste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093174ffb83e097c2e06c0ac9ce688699c1d19c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Zivotinje_izgubljeneDetaljiSkloniste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PIS_projekt.ViewModels.IzgubljeneVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Zivotinje", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IzgubljeneSkloniste", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
  
    ViewData["Title"] = "izgubljeneDetaljiSkloniste";
    Layout = "~/Views/Shared/_LayoutZaposlenik.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h4>Detalji</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
         foreach (var item in Model.izgubljene)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Broj mikročipa\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 20 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.BrojMikrocipa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Ime životinje\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 26 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Naziv pasmine\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 32 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.Pasmina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Vrsta životinje\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 38 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.VrstaZivotinje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Spol\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 44 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.Spol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Kastrat\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 50 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.Kastrat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Slika\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 56 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.Slika));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Lokacija nestanka\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 62 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.LokacijaNestanka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Mjesto\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 68 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.Grad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Datum nestanka\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 74 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.DatumNestanka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Datum prijave\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 80 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.DatumPrijave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Kontakt\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 86 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"
           Write(Html.DisplayFor(model => item.Kontakt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 88 "C:\Users\Tino-Vinko\Documents\GitHub\Lutalice-Info\PIS_projekt\PIS_projekt\Views\Zivotinje\izgubljeneDetaljiSkloniste.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e25886c686a1399819863d8698697f01f34b72110567", async() => {
                WriteLiteral("Povratak");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PIS_projekt.ViewModels.IzgubljeneVM> Html { get; private set; }
    }
}
#pragma warning restore 1591