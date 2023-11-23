using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VasaHotel_main.Areas.Identity.Data;

[assembly: HostingStartup(typeof(VasaHotel_main.Areas.Identity.IdentityHostingStartup))]
namespace VasaHotel_main.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
          /*  builder.ConfigureServices((context, services) => {
                services.AddDbContext<VasaHotelContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VasaHotelContextConnection")));

                services.AddDefaultIdentity<VasaHotelUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<VasaHotelContext>();

            });*/
        }
    }
}