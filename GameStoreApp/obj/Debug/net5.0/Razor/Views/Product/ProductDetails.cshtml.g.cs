#pragma checksum "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b77dc733f43d7d187ff37395f59f4eb3f4743fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductDetails), @"mvc.1.0.view", @"/Views/Product/ProductDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
using Application.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77dc733f43d7d187ff37395f59f4eb3f4743fba", @"/Views/Product/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca80f9cae2f891b4e76c29d441443d87cfc815b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application.ViewModels.InventaryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-lg me-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn-payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
  
    ViewData["title"] = "Carrito de compras";
    int index = 0;
    double sum = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w-100 p-3"" style=""background-color: #fdccbc;"">
  <div class=""container h-100"">
    <div class=""row d-flex justify-content-center align-items-center h-100"">
      <div class=""col"">
        <p><span class=""h2"">Carrito de compras</span></p>

");
#nullable restore
#line 16 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
         if (Model == null || Model.Products.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>El carrito está vacío</h2>\r\n");
#nullable restore
#line 19 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
        }else{
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
             foreach (Application.ViewModels.ProductViewModel item in Model.Products)
           {


#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"card mb-4\">\r\n                  <div class=\"card-body p-4\">\r\n\r\n                      <div class=\"row align-items-center\">\r\n                          <div class=\"col-md-2\">\r\n                              <img");
            BeginWriteAttribute("src", " src=\"", 907, "\"", 927, 1);
#nullable restore
#line 28 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
WriteAttributeValue("", 913, item.ImageUrl, 913, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                   class=""img-fluid"" alt=""Imagen producto"">
                          </div>
                          <div class=""col-md-2 d-flex justify-content-center"">
                              <div>
                                  <p class=""small text-muted mb-4 pb-2"">Nombre</p>
                                  <p class=""lead fw-normal mb-0"">");
#nullable restore
#line 34 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                              </div>
                          </div>
                          <div class=""col-md-2 d-flex justify-content-center"">
                              <div>
                                  <p class=""small text-muted mb-4 pb-2"">Cantidad</p>
                                  <p class=""lead fw-normal mb-0"">1</p>
                              </div>
                          </div>
                          <div class=""col-md-2 d-flex justify-content-center"">
                              <div>
                                  <p class=""small text-muted mb-4 pb-2"">Precio</p>
                                  <p class=""lead fw-normal mb-0"">RD$");
#nullable restore
#line 46 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                              </div>
                          </div>
                          <div class=""col-md-2 d-flex justify-content-center"">
                              <div>
                                  <p class=""small text-muted mb-4 pb-2"">Acción</p>
                                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b77dc733f43d7d187ff37395f59f4eb3f4743fba10656", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                                                                                            WriteLiteral(Model.SavingProductsInventaries.FirstOrDefault(x => x.ProductId == @item.Id).Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                              </div>\r\n                          </div>\r\n\r\n                      </div>\r\n\r\n                  </div>\r\n                </div>\r\n");
#nullable restore
#line 61 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                index++;
                sum += @item.Price;

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"h2\"><span>");
#nullable restore
#line 66 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                       Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> artículos en el carrito</p>

        <div class=""card mb-5"">
          <div class=""card-body p-4"">

            <div class=""float-end"">
              <p class=""mb-0 me-5 d-flex align-items-center"">
                <span class=""small text-muted me-2"">Order total:</span> <span
                  class=""lead fw-normal"">$");
#nullable restore
#line 74 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                                     Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              </p>\r\n            </div>\r\n\r\n          </div>\r\n        </div>\r\n\r\n        <div class=\"d-flex justify-content-end\">\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b77dc733f43d7d187ff37395f59f4eb3f4743fba15055", async() => {
                WriteLiteral("Continuar comprando");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b77dc733f43d7d187ff37395f59f4eb3f4743fba16523", async() => {
                WriteLiteral("Pagar artículos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\Jaime David Terrero\OneDrive\Documentos\GitHub\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                                                             WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n      </div>\r\n    </div>\r\n  </div>\r\n</section>\r\n\r\n<script>\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application.ViewModels.InventaryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
