#pragma checksum "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff48443679c4633a19de45f2e90d48af1fb7d7b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Details_room), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Details_room.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff48443679c4633a19de45f2e90d48af1fb7d7b3", @"/Areas/Admin/Views/Home/Details_room.cshtml")]
    public class Areas_Admin_Views_Home_Details_room : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VasaHotel.Models.Room>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Room</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayNameFor(model => model.Typeroom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
       Write(Html.DisplayFor(model => model.Typeroom.type_room_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit_room\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1332, "\"", 1361, 1);
#nullable restore
#line 47 "C:\Users\DELL 15R\Desktop\Vasa-booking-website\VasaHotel_main\Areas\Admin\Views\Home\Details_room.cshtml"
WriteAttributeValue("", 1347, Model.room_id, 1347, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
