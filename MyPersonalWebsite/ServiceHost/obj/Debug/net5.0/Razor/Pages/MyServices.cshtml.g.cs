#pragma checksum "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fbcd2d63dae8f90d93fcc774de725d5e0b67b31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_MyServices), @"mvc.1.0.razor-page", @"/Pages/MyServices.cshtml")]
namespace ServiceHost.Pages
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
#line 1 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fbcd2d63dae8f90d93fcc774de725d5e0b67b31", @"/Pages/MyServices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyServices : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ContactMe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SiteTheme/assets/images/quote.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lonon-quote-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Articles_Blogs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
  
    ViewData["Title"] = "سرویس ها و تعرفه های من";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""lonon-main"">
    <div class=""lonon-services"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <span class=""heading-meta style-1"">ما چه میکنیم؟</span>
                    <h2 class=""lonon-heading animate-box"" data-animate-effect=""fadeInLeft"">خدمات ما</h2>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 17 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
              foreach (var item in Model.Services)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"col-md-4\">\r\n                     <div class=\"lonon-feature animate-box\" data-animate-effect=\"fadeInLeft\">\r\n                         <div class=\"lonon-icon\">\r\n                             <span");
            BeginWriteAttribute("class", " class=\"", 825, "\"", 860, 2);
#nullable restore
#line 22 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
WriteAttributeValue("", 833, item.ServiceLogo, 833, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 850, "font-35px", 851, 10, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                         </div>\r\n                         <div class=\"lonon-text\">\r\n                             <h3>");
#nullable restore
#line 25 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                            Write(item.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                             <p>\r\n                                 ");
#nullable restore
#line 27 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                            Write(item.ServiceDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                             </p>\r\n                         </div>\r\n                     </div>\r\n                 </div>\r\n");
#nullable restore
#line 32 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""divider1""></div>

    <div class=""lonon-pricing"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <span class=""heading-meta style-1"">تعرفه پلن ها</span>
                    <h2 class=""lonon-heading animate-box"" data-animate-effect=""fadeInLeft"">قیمت پلن های من</h2>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 47 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                 foreach (var item in Model.Plans)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 price-table\">\r\n                        <div class=\"price-box animate-box\" data-animate-effect=\"fadeInLeft\">\r\n                            <h4><strong>");
#nullable restore
#line 51 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                                   Write(item.PlanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\r\n                            <h1 class=\"bold price-price\"><sup></sup> <span class=\"text-danger\">");
#nullable restore
#line 52 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                                                                                          Write(item.PlanPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\r\n                            <div class=\"price-features\">\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 56 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 60 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 64 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 68 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 72 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription5);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 76 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription6);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 80 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription7);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 84 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription8);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 88 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription9);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"text-justify\">\r\n                                    <strong class=\"text-danger\">*</strong>\r\n                                    ");
#nullable restore
#line 92 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                               Write(item.PlanDescription10);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                            <br />\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fbcd2d63dae8f90d93fcc774de725d5e0b67b3115295", async() => {
                WriteLiteral("\r\n                                جهت مشاوره و سفارش پلن تماس بگیرید\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 101 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""divider1""></div>

    <div class=""lonon-clients"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <span class=""heading-meta style-1"">همکاری با مشتریان</span>
                    <h2 class=""lonon-heading animate-box"" data-animate-effect=""fadeInLeft"">مشتریان من</h2>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 118 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                 foreach (var item in Model.Customers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3 animate-box\" data-animate-effect=\"fadeInLeft\">\r\n                        <div class=\"clients\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8fbcd2d63dae8f90d93fcc774de725d5e0b67b3117949", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5618, "~/Pictures/", 5618, 11, true);
#nullable restore
#line 122 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
AddHtmlAttributeValue("", 5629, item.CustomerLogo, 5629, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 122 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
AddHtmlAttributeValue("", 5672, item.LogoAlt, 5672, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 122 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
AddHtmlAttributeValue("", 5694, item.LogoTitle, 5694, 15, false);

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
            WriteLiteral("\r\n                            <p class=\"text-justify text-center topPadding\"> ");
#nullable restore
#line 123 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                                                                       Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 126 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    
    <div class=""divider1""></div>

    <div class=""lonon-testiominal"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <span class=""heading-meta style-1"">مشتریان&nbsp;</span>
                    <h2 class=""lonon-heading animate-box"" data-animate-effect=""fadeInLeft"">نظرات مشتریان من</h2>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 142 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                 foreach (var item in Model.ClientsOpinion)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 animate-box\" data-animate-effect=\"fadeInLeft\">\r\n                        <div class=\"lonon-quote-card\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8fbcd2d63dae8f90d93fcc774de725d5e0b67b3122346", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 146 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
AddHtmlAttributeValue("", 6701, item.ClientName, 6701, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 146 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
AddHtmlAttributeValue("", 6726, item.ClientName, 6726, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <p class=\"text-justify\">\r\n                                ");
#nullable restore
#line 148 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <h5><strong>");
#nullable restore
#line 150 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                                   Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5>\r\n                            <p class=\"occupation\">");
#nullable restore
#line 151 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                                             Write(item.ClientJob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 154 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\MyServices.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div id=""lonon-footer2"">
        <div class=""lonon-narrow-content"">
            <div class=""row"">
                <div class=""col-md-4 animate-box"" data-animate-effect=""fadeInLeft"">
                    <p class=""lonon-lead"">
                        استفاده از مطالب این سایت فقط برای مقاصد غیرتجاری و با ذکر منبع
                        بلامانع است. کلیه حقوق این سایت متعلق به نوید قوامی می‌باشد.
                    </p>
                </div>
                <div class=""col-md-4 animate-box"" data-animate-effect=""fadeInLeft"">
                    <h2 class=""text-center"">
                    </h2>
                </div>
                <div class=""col-md-4 animate-box"" data-animate-effect=""fadeInLeft"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fbcd2d63dae8f90d93fcc774de725d5e0b67b3126757", async() => {
                WriteLiteral(@"
                        <h2 class=""text-center"">
                            مقالات روز دنیای برنامه نویسی و کامپیوتر  <strong class=""text-warning"">برنامه نویسی و کامپیوتر</strong>  را مشاهده فرمایید؟!
                        </h2>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.MyServicesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.MyServicesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.MyServicesModel>)PageContext?.ViewData;
        public ServiceHost.Pages.MyServicesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
