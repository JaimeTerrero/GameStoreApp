#pragma checksum "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5e72bb56a0648efb2d5aa6be9d2431cc8b44739"
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
#line 1 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\_ViewImports.cshtml"
using GameStoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\_ViewImports.cshtml"
using GameStoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5e72bb56a0648efb2d5aa6be9d2431cc8b44739", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca80f9cae2f891b4e76c29d441443d87cfc815b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Application.ViewModels.ProductViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
         if(Model == null || Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>No hay productos</h2>\r\n");
#nullable restore
#line 12 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
        }else{
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
             foreach (Application.ViewModels.ProductViewModel item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4\">\r\n                    <div class=\"card shadow-sm\">\r\n                        \r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 526, "\"", 546, 1);
#nullable restore
#line 18 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 532, item.ImageUrl, 532, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                        <div class=\"card-body\">\r\n                            <h4>");
#nullable restore
#line 21 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div>\r\n                                <small class=\"fw-bold fs-6\">RD$");
#nullable restore
#line 24 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
                                                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Application.ViewModels.ProductViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
