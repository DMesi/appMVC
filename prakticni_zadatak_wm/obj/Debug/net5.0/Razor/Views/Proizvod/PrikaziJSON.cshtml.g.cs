#pragma checksum "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e153f00c352e5f8bddb1c496d77a6a134b5f0221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvod_PrikaziJSON), @"mvc.1.0.view", @"/Views/Proizvod/PrikaziJSON.cshtml")]
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
#line 1 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\_ViewImports.cshtml"
using prakticni_zadatak_wm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\_ViewImports.cshtml"
using prakticni_zadatak_wm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e153f00c352e5f8bddb1c496d77a6a134b5f0221", @"/Views/Proizvod/PrikaziJSON.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20a2b1aedca458f776301ce21f17c1d1074fc9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Proizvod_PrikaziJSON : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prakticni_zadatak_wm.Models.ProizvodJSON>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>PRIKAZ PROIZVODA IZ JSON </h4>\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 9 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
       Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 12 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
       Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </th>
        <th>
            Kategorija
        </th>
        <th>
            Proizvođač
        </th>
        <th>
            Dobavljač
        </th>
        <th>
            Cena
        </th>
        <th></th>
    </tr>


");
#nullable restore
#line 30 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
     if (Model != null && Model.Count() > 0)
    {
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
               Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
               Write(Html.Raw(item.Opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
               Write(Html.DisplayFor(modelItem => item.Kategorija));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
               Write(Html.DisplayFor(modelItem => item.Proizvodjac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dobavljac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 59 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"

        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td colspan=\"4\" class=\"text-center\">\r\n            <b>Nema podataka. Za migraciju:</b><br />\r\n\r\n            add-migration MyMigration -Context App_Data_Base <br />\r\n            update-database -Context App_Data_Base\r\n\r\n        </td>\r\n");
#nullable restore
#line 71 "d:\data\mes7456\Desktop\mvcwm\appMVC\prakticni_zadatak_wm\Views\Proizvod\PrikaziJSON.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prakticni_zadatak_wm.Models.ProizvodJSON>> Html { get; private set; }
    }
}
#pragma warning restore 1591
