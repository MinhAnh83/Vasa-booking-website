#pragma checksum "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Blogs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b0cd4ce9bd44c3c142a1108d88dff7734485a6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blogs_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Blogs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0cd4ce9bd44c3c142a1108d88dff7734485a6e", @"/Areas/Admin/Views/Blogs/Create.cshtml")]
    public class Areas_Admin_Views_Blogs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VasaHotel.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Blogs\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Blog</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"" enctype=""multipart/form-data"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""author_name"" class=""control-label""></label>
                <input asp-for=""author_name"" class=""form-control"" />
                <span asp-validation-for=""author_name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""day_published"" class=""control-label""></label>
                <input asp-for=""day_published"" class=""form-control"" />
                <span asp-validation-for=""day_published"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Title"" class=""control-label""></label>
                <input asp-for=""Title"" class=""form-control"" />
                <span asp-vali");
            WriteLiteral(@"dation-for=""Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Content"" class=""control-label""></label>
                <input asp-for=""Content"" class=""form-control"" type=""text"" />
                <span asp-validation-for=""Content"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
              <h5>Upload image:</h5>
                <input  id=""uploadhinh"" name=""uploadhinh"" accept=""image/*"" type=""file""/>
             
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Blogs\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VasaHotel.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
