#pragma checksum "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d14b3b00fe3c9eb31d405b3c661e79df0ab87522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Rooms), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Rooms.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14b3b00fe3c9eb31d405b3c661e79df0ab87522", @"/Areas/Admin/Views/Home/Rooms.cshtml")]
    public class Areas_Admin_Views_Home_Rooms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VasaHotel.Models.Room>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
  
    ViewData["Title"] = "Manage room";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <a asp-action=\"Create_room\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
           Write(Html.DisplayNameFor(model => model.Typeroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Typeroom.type_room_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a asp-action=\"Edit_room\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1520, "\"", 1548, 1);
#nullable restore
#line 51 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
WriteAttributeValue("", 1535, item.room_id, 1535, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                    <a asp-action=\"Details_room\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1610, "\"", 1638, 1);
#nullable restore
#line 52 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
WriteAttributeValue("", 1625, item.room_id, 1625, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                    <a asp-action=\"Delete_room\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1702, "\"", 1730, 1);
#nullable restore
#line 53 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
WriteAttributeValue("", 1717, item.room_id, 1717, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "D:\BTEC\APPLICATION ASP.NET\VasaHotel_main\VasaHotel_main\Areas\Admin\Views\Home\Rooms.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
