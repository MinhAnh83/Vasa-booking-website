#pragma checksum "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "493f5d1a7441a4d4f4bd098ed587c56e900647cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail_blog), @"mvc.1.0.view", @"/Views/Home/Detail_blog.cshtml")]
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
#line 1 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\_ViewImports.cshtml"
using VasaHotel_main;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\_ViewImports.cshtml"
using VasaHotel_main.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"493f5d1a7441a4d4f4bd098ed587c56e900647cd", @"/Views/Home/Detail_blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a590654be37f68213685a01c63b05ab59a6a919c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail_blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VasaHotel.Models.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500vh"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 27%; margin-bottom: 32px; margin-top: -214px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_blog.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div>

  
    <section class=""blog-details-hero set-bg"" data-setbg="""">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-10 offset-lg-1""  >
                    <div class=""bd-hero-text"">

                        <h2  style=""color:black; margin-top:-38px"">      ");
#nullable restore
#line 19 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_blog.cshtml"
                                                                    Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <ul>\r\n                            <li class=\"b-time\"><i class=\"icon_clock_alt\"></i>  ");
#nullable restore
#line 21 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_blog.cshtml"
                                                                          Write(Html.DisplayFor(model => model.day_published));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><i class=\"icon_profile\"></i>   ");
#nullable restore
#line 22 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_blog.cshtml"
                                                          Write(Html.DisplayFor(model => model.author_name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""blog-details-section"">
        <div class=""container"">
            <div class=""row"" style=""text-align: center"">

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "493f5d1a7441a4d4f4bd098ed587c56e900647cd6773", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1064, "~/Uploads/Images/", 1064, 17, true);
#nullable restore
#line 33 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_blog.cshtml"
AddHtmlAttributeValue("", 1081, Model.Images, 1081, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                
            </div>
            <div class=""row"">
                <div class=""col-lg-10 offset-lg-1"">
                    <div class=""blog-details-text"">
                    
                            <div class=""bd-more-text"">
                                <div class=""bm-item"">
                                    <h5 style=""text-align:center;letter-spacing: 3px"">Content</h5>
                                    <p  style=""text-align: justify;"" >
                                        ");
#nullable restore
#line 45 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_blog.cshtml"
                                   Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
</section>
     
</div>
<div>
   
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "493f5d1a7441a4d4f4bd098ed587c56e900647cd9616", async() => {
                WriteLiteral("Back to Blog page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VasaHotel.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
