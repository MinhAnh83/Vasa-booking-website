#pragma checksum "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc68fd11a4d28e2f19ac83cd6dca0e96ca9b866b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc68fd11a4d28e2f19ac83cd6dca0e96ca9b866b", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VasaHotel.Models.Room>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Quan tri</h1>\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Typeroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Typeroom.type_room_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1518, "\"", 1546, 1);
#nullable restore
#line 52 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1533, item.room_id, 1533, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                    <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1603, "\"", 1631, 1);
#nullable restore
#line 53 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1618, item.room_id, 1618, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                    <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1690, "\"", 1718, 1);
#nullable restore
#line 54 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1705, item.room_id, 1705, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VasaHotel.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
