#pragma checksum "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "051a200bbc0bf02a703670ec34639fc40ef09685"
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
#line 1 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\_ViewImports.cshtml"
using GameStoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\_ViewImports.cshtml"
using GameStoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
using Application.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"051a200bbc0bf02a703670ec34639fc40ef09685", @"/Views/Product/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca80f9cae2f891b4e76c29d441443d87cfc815b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Application.ViewModels.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
  
    ViewData["title"] = "Carrito de compras";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""vh-100"" style=""background-color: #fdccbc;"">
  <div class=""container h-100"">
    <div class=""row d-flex justify-content-center align-items-center h-100"">
      <div class=""col"">
        <p><span class=""h2"">Shopping Cart </span><span class=""h4"">(1 item in your cart)</span></p>

");
#nullable restore
#line 14 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
         if (Model == null || Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>El carrito está vacío</h2>\r\n");
#nullable restore
#line 17 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
        }else{
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
             foreach (Application.ViewModels.ProductViewModel item in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "051a200bbc0bf02a703670ec34639fc40ef096855019", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("               <div class=\"card mb-4\">\r\n                  <div class=\"card-body p-4\">\r\n\r\n                    <div class=\"row align-items-center\">\r\n                      <div class=\"col-md-2\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 936, "\"", 956, 1);
#nullable restore
#line 27 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
WriteAttributeValue("", 942, item.ImageUrl, 942, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                          class=""img-fluid"" alt=""Imagen producto"">
                      </div>
                      <div class=""col-md-2 d-flex justify-content-center"">
                        <div>
                          <p class=""small text-muted mb-4 pb-2"">Name</p>
                          <p class=""lead fw-normal mb-0"">");
#nullable restore
#line 33 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                      </div>
                      <div class=""col-md-2 d-flex justify-content-center"">
                        <div>
                          <p class=""small text-muted mb-4 pb-2"">Color</p>
                          <p class=""lead fw-normal mb-0""><i class=""fas fa-circle me-2"" style=""color: #fdd8d2;""></i>
                            pink rose</p>
                        </div>
                      </div>
                      <div class=""col-md-2 d-flex justify-content-center"">
                        <div>
                          <p class=""small text-muted mb-4 pb-2"">Quantity</p>
                          <p class=""lead fw-normal mb-0"">1</p>
                        </div>
                      </div>
                      <div class=""col-md-2 d-flex justify-content-center"">
                        <div>
                          <p class=""small text-muted mb-4 pb-2"">Price</p>
                          <p class=""lead fw-normal mb-0"">RD");
            WriteLiteral("$");
#nullable restore
#line 52 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                      </div>
                      <div class=""col-md-2 d-flex justify-content-center"">
                        <div>
                          <p class=""small text-muted mb-4 pb-2"">Total</p>
                          <p class=""lead fw-normal mb-0"">RD$");
#nullable restore
#line 58 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                      </div>\r\n                    </div>\r\n\r\n                  </div>\r\n               </div>\r\n");
#nullable restore
#line 65 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\jimke\Documents\GameStoreApp\GameStoreApp\Views\Product\ProductDetails.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
       
        

        <div class=""card mb-5"">
          <div class=""card-body p-4"">

            <div class=""float-end"">
              <p class=""mb-0 me-5 d-flex align-items-center"">
                <span class=""small text-muted me-2"">Order total:</span> <span
                  class=""lead fw-normal"">$799</span>
              </p>
            </div>

          </div>
        </div>

        <div class=""d-flex justify-content-end"">
          <button type=""button"" class=""btn btn-light btn-lg me-2"">Continue shopping</button>
          <button type=""button"" class=""btn btn-primary btn-lg"">Add to cart</button>
        </div>

      </div>
    </div>
  </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Application.ViewModels.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
