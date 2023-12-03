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
        public class InputModel  //InputModel represents input data when editing a role
        {
            public string ID { set; get; }
            [Required(ErrorMessage = "Phải nhập tên role")]
            [Display(Name = "Tên của Role")]
            [StringLength(100, ErrorMessage = "{0} dài {2} đến {1} ký tự.", MinimumLength = 3)]
            public string Name { set; get; }
        }
        [BindProperty]
        public InputModel Input { set; get; }//Input stores input data from the form

        [BindProperty]
        public bool IsUpdate { set; get; }//IsUpdate determines whether there is a role update operation or not
        public IdentityRole role { get; set; }
        public async Task<IActionResult> OnGet(string roleid)//get information about the role based on the roleid passed in
        {
            if (roleid == null) return NotFound("Can't find role ");
            role = await _roleManager.FindByIdAsync(roleid);
            if (role != null)
            {
                Input = new InputModel()   //data will be assigned to Input
                {
                    Name = role.Name 
                };
                return Page();
            }
            return NotFound("Can't find role ");
        }
        public async Task<IActionResult> OnPostAsync(string roleid)  
            //handle the POST request when the user submits the role edit form
        {
            if (roleid == null) return NotFound("Can't find role ");
            role = await _roleManager.FindByIdAsync(roleid);
            if (!ModelState.IsValid)
            {     StatusMessage = null;
                return Page();
            }
            role.Name = Input.Name;
            var result = await _roleManager.UpdateAsync(role);    
                if (result.Succeeded)
                {
                    StatusMessage = $"Bạn vừa đổi tên: {Input.Name}"; //the role name will be updated
                return RedirectToPage("./Index");//the page will redirect to the Index page
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
