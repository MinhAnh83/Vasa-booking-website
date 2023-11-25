using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  VasaHotel.Models;
using VasaHotel_main.Areas.Identity.Data;

namespace VasaHotel_main.Areas.Admin.Role
{
   
    public class RolePageModel : PageModel
    {
        protected readonly RoleManager<IdentityRole> _roleManager;
        protected readonly VasaHotelContext _context;

        [TempData] // Sử dụng Session lưu thông báo
        public string StatusMessage { get; set; }

        public RolePageModel(RoleManager<IdentityRole> roleManager, VasaHotelContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }
    }
}
