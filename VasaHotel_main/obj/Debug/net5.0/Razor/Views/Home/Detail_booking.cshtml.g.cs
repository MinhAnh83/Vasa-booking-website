#pragma checksum "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b311adfb15d907bb92bcb772fc3edc013f11768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail_booking), @"mvc.1.0.view", @"/Views/Home/Detail_booking.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b311adfb15d907bb92bcb772fc3edc013f11768", @"/Views/Home/Detail_booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a590654be37f68213685a01c63b05ab59a6a919c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail_booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VasaHotel.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/hero/hero-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("549px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px;height: 300px; border-radius: 5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <div style=\"text-align: center;\">\r\n        <h3>Booking details</h3>\r\n        <h5>Customer_<span>    ");
#nullable restore
#line 13 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
                          Write(Html.DisplayFor(model => model.Customer.customer_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n    </div>\r\n   \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4b311adfb15d907bb92bcb772fc3edc013f117685134", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            <div class=\"row\">\r\n        <dt class=\"col-sm-4\">\r\n            Checkin day\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 28 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
       Write(Html.DisplayFor(model => model.checkin_day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Checkout day\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 34 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
       Write(Html.DisplayFor(model => model.checkout_day));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Payment methods\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 40 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
       Write(Html.DisplayFor(model => model.method_payment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Payment status\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n");
#nullable restore
#line 46 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
              
                string paymentStatus = Model.is_payment == false ? "unpaid" : "paid";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <p> ");
#nullable restore
#line 50 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
           Write(paymentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 54 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
       Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 57 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
       Write(Html.DisplayFor(model => model.Room.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            Total price\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 63 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
       Write(Html.DisplayFor(model => model.total_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n      \r\n        <h7 style=\"width: 100%\">Image of rooms</h7>\r\n        <br></br>\r\n        <div style=\"width: 100%\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4b311adfb15d907bb92bcb772fc3edc013f117689536", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1879, "~/Upload/Images/", 1879, 16, true);
#nullable restore
#line 69 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Views\Home\Detail_booking.cshtml"
AddHtmlAttributeValue("", 1895, Model.Room.ImageName, 1895, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
       
        <br><br />
            <div style=""width: 100%;margin-top: 20px"">
                <button class=""button-accept"" data-toggle=""modal"" data-target=""#exampleModal"">
                    Accept
                </button>
            </div>
        
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Notification</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        You have successfully booked your room! Thank you for trusting and using our services.
    ");
            WriteLiteral(@"                </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                       
                        <a  href=""/Home"" class=""button-home"">Go to Home</a>
                    </div>
                </div>
            </div>
        </div>
");
            WriteLiteral(@"
</div>
       
</div>

      
    </dl>
</div>


<style>
    .button-accept {
        border-radius: 5px;
        padding: 10px;
        background-color: pink;
        color: white;
        font-weight: 700;
        letter-spacing: 2px;
    }
        .button-accept:hover {
            background: #ed546e
        }
    .button-home {
        border-radius: 5px;
        padding: 10px;
        background-color: deepskyblue;
        color: white;
        font-weight: 700;
        letter-spacing: 2px;
    }

        .button-home:hover {
            background: blue;
        }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VasaHotel.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
