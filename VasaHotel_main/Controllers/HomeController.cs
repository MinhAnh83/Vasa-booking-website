using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VasaHotel.Models;
using VasaHotel_main.Areas.Identity.Data;
using VasaHotel_main.Models;

namespace VasaHotel_main.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VasaHotelContext _context;
        public IList<Room> Rooms { get; set; }

        public HomeController(ILogger<HomeController> logger, VasaHotelContext context)
        {
            _logger = logger;
           _context = context;
        }

      
        // GET: Home
        public async Task<IActionResult> Index()
        {
            var vasaHotelContext = _context.Room.Include(r => r.Typeroom).ToList();
          
            return View(vasaHotelContext);
        }

       


        // GET: Home/Detail_room/
        public async Task<IActionResult> Detail_room(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.Typeroom)
                .FirstOrDefaultAsync(m => m.room_id == id);

          
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        public IActionResult Contact()
        {
            return View();
        }

        // GET: Blog
        public async Task<IActionResult> Blog()

        {
            return View(await _context.Blog.ToListAsync());
        }


        // GET: Blogs/Detail_blog/5
        public async Task<IActionResult> Detail_blog(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog
                .FirstOrDefaultAsync(m => m.blog_id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
