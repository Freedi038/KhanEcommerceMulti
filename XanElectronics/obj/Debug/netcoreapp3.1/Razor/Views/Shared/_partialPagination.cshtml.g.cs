#pragma checksum "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c1396c885274d72016913a5938eecceb4636e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__partialPagination), @"mvc.1.0.view", @"/Views/Shared/_partialPagination.cshtml")]
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
#line 1 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\_ViewImports.cshtml"
using XanElectronics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\_ViewImports.cshtml"
using XanElectronics.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1396c885274d72016913a5938eecceb4636e8c", @"/Views/Shared/_partialPagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71df2b8f05ac91fb957a43b85b0a02d10ac29bd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__partialPagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("first-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 col-lg-4 col-xl-3 mb-30\">\n        <div class=\"card product-card\">\n            <div class=\"card-body\">\n                <div class=\"product-thumbnail position-relative\">\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                     if (item.DisCountRate > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-success top-left\">-");
#nullable restore
#line 11 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                                                               Write(item.DisCountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                     if (item.IsNew)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-danger top-right\">New</span>\n");
#nullable restore
#line 16 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c1396c885274d72016913a5938eecceb4636e8c6520", async() => {
                WriteLiteral("\n");
#nullable restore
#line 18 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                         foreach (var prImage in item.ProductImages.Take(1))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2c1396c885274d72016913a5938eecceb4636e8c7115", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 849, "~/assets/img/product/", 849, 21, true);
#nullable restore
#line 20 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
AddHtmlAttributeValue("", 870, prImage.ImageUrl, 870, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 21 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <!-- product links -->\n");
            WriteLiteral("                    <!-- product links end-->\n                </div>\n                <div class=\"product-desc py-0\">\n                    <h3 class=\"title\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c1396c885274d72016913a5938eecceb4636e8c11522", async() => {
                WriteLiteral("\n                            ");
#nullable restore
#line 50 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </h3>\n                    <div class=\"star-rating\">\n");
#nullable restore
#line 54 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                         for (int i = 0; i < item.Star; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"ion-ios-star\"></span>\n");
#nullable restore
#line 57 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                    <div class=\"d-flex align-items-center justify-content-between\">\n\n");
#nullable restore
#line 61 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                         if (item.DisCountRate > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6 class=\"product-price\">\n                                <del class=\"del\">$ ");
#nullable restore
#line 64 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                                              Write(item.Price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\n                                <span class=\"onsale\">$ ");
#nullable restore
#line 65 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                                                  Write(item.ResultPrice.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </h6>\n");
#nullable restore
#line 67 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h6 class=\"product-price\">$ ");
#nullable restore
#line 70 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                                                   Write(item.Price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n");
#nullable restore
#line 71 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button class=\"pro-btn\">\n                            <i class=\"icon-basket addToBasket\" data-id=\"");
#nullable restore
#line 73 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></i>\n                        </button>\n                    </div>\n                </div>\n            </div>\n        </div>\n        <!-- product-list End -->\n    </div>\n");
#nullable restore
#line 81 "C:\Users\User\Desktop\KhanEcommerce-main\XanElectronics\Views\Shared\_partialPagination.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591