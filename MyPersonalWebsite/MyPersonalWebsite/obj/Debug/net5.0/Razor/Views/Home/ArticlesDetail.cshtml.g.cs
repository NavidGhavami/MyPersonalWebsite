#pragma checksum "F:\Programming\Codes and projects\MyPersonalWebsite\MyPersonalWebsite\MyPersonalWebsite\Views\Home\ArticlesDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "955872bc40e5fe730d3faac5c1f525f532881b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ArticlesDetail), @"mvc.1.0.view", @"/Views/Home/ArticlesDetail.cshtml")]
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
#line 1 "F:\Programming\Codes and projects\MyPersonalWebsite\MyPersonalWebsite\MyPersonalWebsite\Views\_ViewImports.cshtml"
using MyPersonalWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Programming\Codes and projects\MyPersonalWebsite\MyPersonalWebsite\MyPersonalWebsite\Views\_ViewImports.cshtml"
using MyPersonalWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"955872bc40e5fe730d3faac5c1f525f532881b66", @"/Views/Home/ArticlesDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46610d5b4053f13f3a71516a1948a0712106a886", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ArticlesDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Articles>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("full-max-width"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Programming\Codes and projects\MyPersonalWebsite\MyPersonalWebsite\MyPersonalWebsite\Views\Home\ArticlesDetail.cshtml"
  
    ViewData["Title"] = "???????????? ??????????";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row card-container"">
						
					<!--
						Card Wrap
					-->
                    <div class=""card-wrap col col-m-12 col-t-12 col-d-8 col-d-lg-6"" data-simplebar=""init""><div class=""simplebar-track vertical"" style=""visibility: visible;""><div class=""simplebar-scrollbar"" style=""visibility: visible; top: 0px; height: 339px;""></div></div><div class=""simplebar-track horizontal"" style=""visibility: hidden;""><div class=""simplebar-scrollbar""></div></div><div class=""simplebar-scroll-content"" style=""padding-left: 17px; margin-bottom: -34px;""><div class=""simplebar-content"" style=""padding-bottom: 17px; margin-left: -17px;"">
						
                            <!-- Blog Image -->
                            <div class=""card-image col col-m-12 col-t-12 col-d-4 col-d-lg-6"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "955872bc40e5fe730d3faac5c1f525f532881b664696", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 918, "~/images/blog/", 918, 14, true);
#nullable restore
#line 14 "F:\Programming\Codes and projects\MyPersonalWebsite\MyPersonalWebsite\MyPersonalWebsite\Views\Home\ArticlesDetail.cshtml"
AddHtmlAttributeValue("", 932, Model.ArticleImage, 932, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
						
                            <!--
                            Inner Top
                            -->
                            <div class=""content inner-top"">
                                <div class=""row"">
                                    <div class=""col col-m-12 col-t-12 col-d-12 col-d-lg-12"">
                                        <div class=""title-bg"">????????????</div>
                                    </div>
                                </div>
                            </div>

                            <!--
                            Blog Single
                            -->
                            <div class=""content blog-single"">

                                <!-- content -->
                                <div class=""row"">
                                    <div class=""col col-m-12 col-t-12 col-d-12 col-d-lg-12"">
                                        <div class=""post-box card-box"">

                         ");
            WriteLiteral("                   <!-- blog detail -->\r\n                                            <h1>");
#nullable restore
#line 39 "F:\Programming\Codes and projects\MyPersonalWebsite\MyPersonalWebsite\MyPersonalWebsite\Views\Home\ArticlesDetail.cshtml"
                                           Write(Model.ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                            <div class=\"blog-detail\">???????????? :  ");
#nullable restore
#line 40 "F:\Programming\Codes and projects\MyPersonalWebsite\MyPersonalWebsite\MyPersonalWebsite\Views\Home\ArticlesDetail.cshtml"
                                                                          Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> \r\n\r\n                                            <!-- blog content -->\r\n                                            <div class=\"blog-content\">\r\n\t\t\t\t\t\t\t\t\t\t\t\r\n                                                ");
#nullable restore
#line 45 "F:\Programming\Codes and projects\MyPersonalWebsite\MyPersonalWebsite\MyPersonalWebsite\Views\Home\ArticlesDetail.cshtml"
                                           Write(Model.ArticleDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </div>\r\n\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n");
            WriteLiteral("\r\n                            </div>\r\n\t\t\t\t\t\t\r\n\r\n                        </div>\r\n                    </div>\r\n                        </div>\r\n\t\t\t\t\t\t\r\n\t\t\t\t</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Articles> Html { get; private set; }
    }
}
#pragma warning restore 1591
