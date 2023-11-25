using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore; 
using VasaHotel_main.Areas.Identity.Data;

namespace VasaHotel_main.Areas.Admin.User
{
    public class AddRoleModel : PageModel
    {
        private readonly UserManager<VasaHotelUser> _userManager;
        private readonly SignInManager<VasaHotelUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AddRoleModel(UserManager<VasaHotelUser> userManager, SignInManager<VasaHotelUser> signInManager, RoleManager<IdentityRole> roleManager) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
    

        public VasaHotelUser user { get; set; }
        [TempData]
        public string StatusMessage { get; set; }

        public const int ITEMS_PER_PAGE = 10;
        public SelectList allRoles { get; set; }
       
        [BindProperty]
        [DisplayName("Cac role gan cho User")]
        public string[] RoleNames { get; set; }
        public async Task<IActionResult> OnGetAsync(string id) 
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound("Don't have user");
            }

            user = await _userManager.FindByIdAsync(id);
            if(user == null)
            {
                return NotFound($"Can't find user, id = {id}");
            }
           RoleNames= (await _userManager.GetRolesAsync(user)).ToArray<string>();
            List<string> roleNames = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            allRoles = new SelectList(roleNames);
            return Page();
          //  var qr = _userManager.Users.OrderBy(u => u.UserName);
        
        }

        public async Task<IActionResult> OnPostAsync(string id) 
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound("Don't have user");
            }

            user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound($"Can't find user, id = {id}");
            }
            var OldRoleNames = (await _userManager.GetRolesAsync(user)).ToArray();
            var deleteRoles = OldRoleNames.Where(r => !RoleNames.Contains(r));
            var addRoles = RoleNames.Where(r => !OldRoleNames.Contains(r));

            List<string> roleNames = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            allRoles = new SelectList(roleNames);
            var resultDelete = await _userManager.RemoveFromRolesAsync(user, deleteRoles);
            if (!resultDelete.Succeeded)
            {
                resultDelete.Errors.ToList().ForEach(error =>
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                });
                return Page();
            }

            var resultAdd = await _userManager.AddToRolesAsync(user, addRoles);
            if (!resultAdd.Succeeded)
            {
                resultAdd.Errors.ToList().ForEach(error =>
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                });
                return Page();
            }
            StatusMessage = $"Vua cap nhat role cho user :{user.UserName}";
            return RedirectToPage("./Index");
            
        }
    }
}
