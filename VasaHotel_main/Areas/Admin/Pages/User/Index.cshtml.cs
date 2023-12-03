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
using VasaHotel_main.Constants;

namespace VasaHotel_main.Areas.Admin.User
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<VasaHotelUser> _userManager;

        public IndexModel(UserManager<VasaHotelUser> userManager) //accepts a reference to UserManager
        {
            _userManager = userManager;
        }
        public class UserAndRole : VasaHotelUser
        {
            public string RoleNames { get; set; }
        }
        //The UserAndRole class is created to extend the VasaHotelUser class
        //and add a RoleNames property to store the names of user roles
        public List<UserAndRole> users { set; get; }
        //The list of users is declared

        [TempData]
        public string StatusMessage { get; set; }//The StatusMessage property is used to store messages temporarily

        public const int ITEMS_PER_PAGE = 10;
        //The constant ITEMS_PER_PAGE is defined to specify the number of items to display per page
        [BindProperty(SupportsGet = true, Name = "p")]
        public int currentPage { get; set; }//store the current page number
        public int countPage { get; set; }//store the number of pages
        public int totalUser { get; set; }//store the total number of users
      
        public async Task OnGet()
        {
            var qr = _userManager.Users.OrderBy(u => u.UserName); //Get the list of users from UserManager
            totalUser = await qr.CountAsync();
            var qr1 = qr.Select(u => new UserAndRole()
            {
                Id=u.Id,
                UserName=u.UserName,
            });
            users = await qr1.ToListAsync();
            foreach(var user in users) 
            {
                var roles = await _userManager.GetRolesAsync(user);
                //get the list of roles for each user and store it in the RoleNames property of UserAndRole
                user.RoleNames = string.Join(",", roles);
            }

        }

        public void OnPost() => RedirectToPage();//redirects the user to the current page
    }
}
