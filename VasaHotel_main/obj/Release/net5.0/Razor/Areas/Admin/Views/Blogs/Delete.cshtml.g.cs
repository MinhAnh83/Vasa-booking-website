#pragma checksum "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc946b0d511811f516b4daa67ab6705674483082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blogs_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Blogs/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc946b0d511811f516b4daa67ab6705674483082", @"/Areas/Admin/Views/Blogs/Delete.cshtml")]
    public class Areas_Admin_Views_Blogs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VasaHotel.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Blog</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.author_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.author_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.day_published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.day_published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Images));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Blogs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Images));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""blog_id"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VasaHotel.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
