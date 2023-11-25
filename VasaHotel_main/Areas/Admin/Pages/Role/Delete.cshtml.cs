using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VasaHotel_main.Areas.Admin.Role;
using VasaHotel_main.Areas.Identity.Data;

namespace VasaHotel_main.Areas.Admin.Role
{
    public class DeleteModel : RolePageModel
    {
        public DeleteModel(RoleManager<IdentityRole> roleManager, VasaHotelContext context) : base(roleManager, context)
        {
        }

       
      

        [BindProperty]
        public bool IsUpdate { set; get; }
        public IdentityRole role { get; set; }
        public async Task<IActionResult> OnGet(string roleid)
        {
            if (roleid == null) return NotFound("Can't find role ");
            role = await _roleManager.FindByIdAsync(roleid);
            if (role == null)
            {
                return NotFound("Can't find role ");
            }
            return Page();

        }
        
        public async Task<IActionResult> OnPostAsync(string roleid)
        {
            if (roleid == null) return NotFound("Can't find role ");
            role = await _roleManager.FindByIdAsync(roleid);
            if (roleid == null) return NotFound("Can't find role ");
           

            var result = await _roleManager.DeleteAsync(role);
                
                if (result.Succeeded)
                {
                    StatusMessage = $"You just delete role: {role.Name}";
                    return RedirectToPage("./Index");
                }
                else
                {
                    StatusMessage = "Error: ";
                    foreach (var er in result.Errors)
                    {
                        StatusMessage += er.Description;
                    }
                }
            

            return Page();

        }
    }
}
