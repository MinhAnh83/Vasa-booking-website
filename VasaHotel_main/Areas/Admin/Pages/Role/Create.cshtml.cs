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
    public class CreateModel : RolePageModel
    {
        public CreateModel(RoleManager<IdentityRole> roleManager, VasaHotelContext context) : base(roleManager, context)
        {
        }
        public class InputModel
        {      public string ID { set; get; }
            [Required(ErrorMessage = "Phải nhập tên role")]
            [Display(Name = "Tên của Role")]
            [StringLength(100, ErrorMessage = "{0} dài {2} đến {1} ký tự.", MinimumLength = 3)]
            public string Name { set; get; }
        }
        [BindProperty]
        public InputModel Input { set; get; }
        [BindProperty]
        public bool IsUpdate { set; get; }
        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPostAsync()
        {  if (!ModelState.IsValid)
            {
                StatusMessage = null;
                return Page();
            }
                // Create new
                var newRole = new IdentityRole(Input.Name);
                // Create a new role 
                var rsNewRole = await _roleManager.CreateAsync(newRole);
                if (rsNewRole.Succeeded)
                {
                    StatusMessage = $"Đã tạo role mới thành công: {newRole.Name}";
                //Export information that created the role successfully
                    return RedirectToPage("./Index");
                }
                else
                {
                    StatusMessage = "Error: ";
                    foreach (var er in rsNewRole.Errors)
                    {
                        StatusMessage += er.Description;
                    }
                }
            

            return Page();

        }
    }
}
