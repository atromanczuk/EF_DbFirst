#pragma checksum "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\Animal\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f0409b6e2b04d8a93963155ce9220aa0994c952"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Listar), @"mvc.1.0.view", @"/Views/Animal/Listar.cshtml")]
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
#line 1 "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\_ViewImports.cshtml"
using DbFirst.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\_ViewImports.cshtml"
using DbFirst.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f0409b6e2b04d8a93963155ce9220aa0994c952", @"/Views/Animal/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"260edd3fd627d7d519fb5f141d2c232d51611cdf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Animal_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DbFirst.Data.EF.Animal>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t<table>\r\n\t\t<tr>\r\n\t\t\t<th>Nombre</th>\r\n\t\t\t<th>Peso</th>\r\n\t\t\t<th>Edad</th>\r\n\t\t\t<th>Tipo</th>\r\n\t\t</tr>\r\n");
#nullable restore
#line 10 "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\Animal\Listar.cshtml"
         foreach (var animal in Model)
	   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t   <tr>\n\t\t\t   <td>");
#nullable restore
#line 13 "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\Animal\Listar.cshtml"
              Write(animal.NombreEspecie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t   <td>");
#nullable restore
#line 14 "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\Animal\Listar.cshtml"
              Write(animal.PesoPromedio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t   <td>");
#nullable restore
#line 15 "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\Animal\Listar.cshtml"
              Write(animal.EdadPromedio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t   <td>");
#nullable restore
#line 16 "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\Animal\Listar.cshtml"
              Write(animal.IdTipoAnimalNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t   </tr>\n");
#nullable restore
#line 18 "C:\Users\NB-81\Desktop\PW3\EntityFramework\db_first\DbFirst\DbFirst.Web\Views\Animal\Listar.cshtml"
		   
	   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DbFirst.Data.EF.Animal>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
