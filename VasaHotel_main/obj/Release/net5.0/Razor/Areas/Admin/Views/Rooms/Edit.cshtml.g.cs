#pragma checksum "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Rooms\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ba2e4947ada6195a63545b5a2342fb9e8dbc08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Rooms_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Rooms/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ba2e4947ada6195a63545b5a2342fb9e8dbc08", @"/Areas/Admin/Views/Rooms/Edit.cshtml")]
    public class Areas_Admin_Views_Rooms_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VasaHotel.Models.Room>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Rooms\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml"; Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Room</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""room_id"" />
            <div class=""form-group"">
                <label asp-for=""TyperoomID"" class=""control-label""></label>
                <select asp-for=""TyperoomID"" class=""form-control"" asp-items=""ViewBag.TyperoomID""></select>
                <span asp-validation-for=""TyperoomID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Status"" class=""control-label""></label>
                <input asp-for=""Status"" class=""form-control"" />");
            WriteLiteral(@"
                <span asp-validation-for=""Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Image"" class=""control-label""></label>
                <input asp-for=""Image"" class=""form-control"" />
                <span asp-validation-for=""Image"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VasaHotel.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591
