#pragma checksum "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Bookings\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b07715b8fee36e6aad306999c7c0f3621c5e1d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Bookings_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Bookings/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b07715b8fee36e6aad306999c7c0f3621c5e1d6", @"/Areas/Admin/Views/Bookings/Edit.cshtml")]
    public class Areas_Admin_Views_Bookings_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VasaHotel.Models.Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Bookings\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Booking</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""booking_id"" />
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
                <input asp-for=""method_payment"" class=""form-c");
            WriteLiteral(@"ontrol"" />
                <span asp-validation-for=""method_payment"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""is_payment"" /> ");
#nullable restore
#line 34 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Bookings\Edit.cshtml"
                                                                       Write(Html.DisplayNameFor(model => model.is_payment));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""CustomerID"" class=""control-label""></label>
                <select asp-for=""CustomerID"" class=""form-control"" asp-items=""ViewBag.CustomerID""></select>
                <span asp-validation-for=""CustomerID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RoomID"" class=""control-label""></label>
                <select asp-for=""RoomID"" class=""form-control"" asp-items=""ViewBag.RoomID""></select>
                <span asp-validation-for=""RoomID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""total_price"" class=""control-label""></label>
                <input asp-for=""total_price"" class=""form-control"" />
                <span asp-validation-for=""total_price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
               ");
            WriteLiteral(" <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 64 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Bookings\Edit.cshtml"
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
