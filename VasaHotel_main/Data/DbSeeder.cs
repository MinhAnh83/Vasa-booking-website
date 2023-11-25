using System;
using System.Collections.Generic;
using System.Linq;
using VasaHotel_main.Constants;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using VasaHotel_main.Areas.Identity.Data;
using Microsoft.Extensions.DependencyInjection;

namespace VasaHotel_main.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceScopeFactory scopeFactory)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<VasaHotelUser>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
                await roleManager.CreateAsync(new IdentityRole(Roles.Staff.ToString()));

                // creating admin

                var user = new VasaHotelUser
                {
                    LastName = "Tran",
                    FirstName="Anh",
                    Email = "admin@gmail.com",
                    EmailConfirmed = true
                    
                };
                var userInDb = await userManager.FindByEmailAsync(user.Email);
                if (userInDb == null)
                {
                    await userManager.CreateAsync(user, "Admin@123");
                    await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
                }
            }
        }

       
    }
    }
