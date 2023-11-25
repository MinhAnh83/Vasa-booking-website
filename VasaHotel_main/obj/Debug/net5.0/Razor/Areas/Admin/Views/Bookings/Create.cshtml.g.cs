#pragma checksum "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Bookings\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc6fc6b4996179fea4d0e72fe5bbc6f92b12fdd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bookings_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Bookings/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6fc6b4996179fea4d0e72fe5bbc6f92b12fdd2", @"/Areas/Admin/Views/Bookings/Create.cshtml")]
    public class Areas_Admin_Views_Bookings_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VasaHotel.Models.Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Bookings\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Booking</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""checkout_day"" class=""control-label""></label>
                <input asp-for=""checkout_day"" class=""form-control"" />
                <span asp-validation-for=""checkout_day"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""checkin_day"" class=""control-label""></label>
                <input asp-for=""checkin_day"" class=""form-control"" />
                <span asp-validation-for=""checkin_day"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""method_payment"" class=""control-label""></label>
                <input asp-for=""method_payment"" class=""form-control"" />
                <span asp-validation-for=""");
            WriteLiteral("method_payment\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"is_payment\" /> ");
#nullable restore
#line 33 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Bookings\Create.cshtml"
                                                                       Write(Html.DisplayNameFor(model => model.is_payment));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""CustomerID"" class=""control-label""></label>
               #
                <select asp-for=""CustomerID"" class=""form-control"" asp-items=""ViewBag.CustomerID""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""RoomID"" class=""control-label""></label>
                <select asp-for=""RoomID"" class =""form-control"" asp-items=""ViewBag.RoomID""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""total_price"" class=""control-label""></label>
                <input asp-for=""total_price"" class=""form-control"" />
                <span asp-validation-for=""total_price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-a");
            WriteLiteral("ction=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Bookings\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
