using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VasaHotel_main.Areas.Identity.Data;

namespace VasaHotel_main.Areas.Admin.Role
{     [Authorize(Roles="Admin")]
    //Only users with the "Admin" role are allowed to access this page
    public class IndexModel : RolePageModel
    {
        public IndexModel(RoleManager<IdentityRole> roleManager, VasaHotelContext context) : base(roleManager, context)
        {
        }
        public List<IdentityRole> roles { set; get; }
        //roles property of type List to store a list of roles in the system
        public async Task OnGet() 
        { roles = await _roleManager.Roles.ToListAsync(); }
        //get the list of roles from RoleManager and assign it to the roles property

        public void OnPost() => RedirectToPage();
    }
}
