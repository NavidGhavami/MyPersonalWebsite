#pragma checksum "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2943fb6966592baf613b283517b9a024725a4c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_ProjectDetails), @"mvc.1.0.razor-page", @"/Pages/ProjectDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2943fb6966592baf613b283517b9a024725a4c4f", @"/Pages/ProjectDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProjectDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mb-30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/MyServices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
  
    ViewData["Title"] = "جزییات پروژه";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""lonon-main"">
    <div class=""lonon-projects"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <span class=""heading-meta style-1"">جزییات پروژه</span>
                    <h2 class=""lonon-heading animate-box"" data-animate-effect=""fadeInLeft"">");
#nullable restore
#line 16 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
                                                                                      Write(Model.ProjectDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 image-content animate-box fadeInLeft animated\" data-animate-effect=\"fadeInLeft\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2943fb6966592baf613b283517b9a024725a4c4f5168", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 732, "~/Pictures/", 732, 11, true);
#nullable restore
#line 21 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 743, Model.ProjectDetails.FirstPicture, 743, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 784, Model.ProjectDetails.PictureAlt, 784, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 825, Model.ProjectDetails.PictureTitle, 825, 34, false);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6 image-content animate-box fadeInLeft animated\" data-animate-effect=\"fadeInLeft\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2943fb6966592baf613b283517b9a024725a4c4f8026", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1060, "~/Pictures/", 1060, 11, true);
#nullable restore
#line 24 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1071, Model.ProjectDetails.SecondPicture, 1071, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1113, Model.ProjectDetails.PictureAlt, 1113, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1154, Model.ProjectDetails.PictureTitle, 1154, 34, false);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6 image-content animate-box fadeInLeft animated\" data-animate-effect=\"fadeInLeft\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2943fb6966592baf613b283517b9a024725a4c4f10893", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1389, "~/Pictures/", 1389, 11, true);
#nullable restore
#line 27 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1400, Model.ProjectDetails.ThirdPicture, 1400, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1441, Model.ProjectDetails.PictureAlt, 1441, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1482, Model.ProjectDetails.PictureTitle, 1482, 34, false);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6 image-content animate-box fadeInLeft animated\" data-animate-effect=\"fadeInLeft\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2943fb6966592baf613b283517b9a024725a4c4f13760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1717, "~/Pictures/", 1717, 11, true);
#nullable restore
#line 30 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1728, Model.ProjectDetails.ForthPicture, 1728, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1769, Model.ProjectDetails.PictureAlt, 1769, 32, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
AddHtmlAttributeValue("", 1810, Model.ProjectDetails.PictureTitle, 1810, 34, false);

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
            </div>
            <div class=""row"">
                <div class=""col-md-12 sticky-parent animate-box fadeInLeft animated"" data-animate-effect=""fadeInLeft"">
                    <div id=""sticky_item"">
                        <div class=""project-desc"">
                            <h2>");
#nullable restore
#line 37 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
                           Write(Model.ProjectDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>\r\n                                ");
#nullable restore
#line 39 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
                           Write(Html.Raw(Model.ProjectDetails.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>

                            <p>
                                <div class=""row"">
                                    <b class=""rightPadding"">
                                        نام پروژه: &nbsp;
                                    </b>
                                    <b class=""text-primary rightPadding"">
                                        ");
#nullable restore
#line 48 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
                                   Write(Model.ProjectDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </b>
                                </div>
                                <br />

                                <div class=""row"">
                                    <b class=""rightPadding"">
                                        دسته بندی: &nbsp;
                                    </b>
                                    <b class=""text-danger rightPadding"">
                                        ");
#nullable restore
#line 58 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
                                   Write(Model.ProjectDetails.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </b>
                                </div>
                                <br />

                                <div class=""row"">
                                    <b class=""rightPadding"">
                                        نام مشتری / شرکت: &nbsp;
                                    </b>
                                    <b class=""text-primary rightPadding"">
                                        ");
#nullable restore
#line 68 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
                                   Write(Model.ProjectDetails.Customer);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </b>
                                </div>
                                <br />

                                <div class=""row"">
                                    <b class=""rightPadding"">
                                        تکنولوژی: &nbsp;
                                    </b>
                                    <b class=""text-danger rightPadding"">
                                        ");
#nullable restore
#line 78 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
                                   Write(Model.ProjectDetails.Technology);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </b>
                                </div>
                                <br />

                                <div class=""row"">
                                    <b class=""rightPadding"">
                                        آدرس سایت: &nbsp;
                                    </b>
                                    <b>
                                        <a class=""text-primary rightPadding""");
            BeginWriteAttribute("href", " href=\"", 4660, "\"", 4696, 1);
#nullable restore
#line 88 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
WriteAttributeValue("", 4667, Model.ProjectDetails.UrlLink, 4667, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 89 "E:\Programming\Codes and projects\My Personal Website (Navid Ghavami)\MyPersonalWebsite\ServiceHost\Pages\ProjectDetails.cshtml"
                                       Write(Model.ProjectDetails.UrlLink);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </b>
                                </div>
                                <br />

                            </p>
                        </div>
                    </div>
                </div>
            </div>
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
                <div class=""col-md-4 animat");
            WriteLiteral("e-box\" data-animate-effect=\"fadeInLeft\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2943fb6966592baf613b283517b9a024725a4c4f22940", async() => {
                WriteLiteral("\r\n                        <h2 class=\"text-center\">\r\n                            خدمات و تعرفه های  <strong class=\"text-warning\">من</strong>  را مشاهده فرمایید!\r\n                        </h2>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ProjectDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProjectDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProjectDetailsModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ProjectDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591