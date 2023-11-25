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
        public IndexModel(UserManager<VasaHotelUser> userManager) 
        {
            _userManager = userManager;
        }
        public class UserAndRole : VasaHotelUser
        {
            public string RoleNames { get; set; }
        }
        public List<UserAndRole> users { set; get; }

        [TempData]
        public string StatusMessage { get; set; }

        public const int ITEMS_PER_PAGE = 10;
        [BindProperty(SupportsGet = true, Name = "p")]
        public int currentPage { get; set; }
        public int countPage { get; set; }
        public int totalUser { get; set; }
        public async Task OnGet()
        {
            var qr = _userManager.Users.OrderBy(u => u.UserName);
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
                user.RoleNames = string.Join(",", roles);
            }

        }

        public void OnPost() => RedirectToPage();
    }
}
