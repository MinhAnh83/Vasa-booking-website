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
    public class EditModel : RolePageModel
    {
        public EditModel(RoleManager<IdentityRole> roleManager, VasaHotelContext context) : base(roleManager, context)
        {
        }

        public class InputModel
        {
            public string ID { set; get; }

            [Required(ErrorMessage = "Phải nhập tên role")]
            [Display(Name = "Tên của Role")]
            [StringLength(100, ErrorMessage = "{0} dài {2} đến {1} ký tự.", MinimumLength = 3)]
            public string Name { set; get; }

        }
        [BindProperty]
        public InputModel Input { set; get; }

        [BindProperty]
        public bool IsUpdate { set; get; }
        public IdentityRole role { get; set; }
        public async Task<IActionResult> OnGet(string roleid)
        {
            if (roleid == null) return NotFound("Can't find role ");
            role = await _roleManager.FindByIdAsync(roleid);
            if (role != null)
            {
                Input = new InputModel()
                {
                    Name = role.Name
                };
                return Page();
            }
            return NotFound("Can't find role ");

        }
        
        public async Task<IActionResult> OnPostAsync(string roleid)
        {
            if (roleid == null) return NotFound("Can't find role ");
            role = await _roleManager.FindByIdAsync(roleid);
            if (roleid == null) return NotFound("Can't find role ");
            if (!ModelState.IsValid)
            {
                StatusMessage = null;
                return Page();
            }

            role.Name = Input.Name;
            var result = await _roleManager.UpdateAsync(role);
                
                if (result.Succeeded)
                {
                    StatusMessage = $"Bạn vừa đổi tên: {Input.Name}";
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
