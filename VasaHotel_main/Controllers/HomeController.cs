using Microsoft.AspNetCore.Authorization;
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
  
 //  [Authorize(Roles = "Administrator, Staff, Customer")]
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


        static decimal priceroom { get; set; }
        static int bookingid { get; set; }

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
            priceroom = room.Typeroom.Price;
            TempData["roomid"] = room.room_id; 
         

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
        // GET: Home/Review_page
        public async Task<IActionResult> Review_page(int? id)

        {
            var vasaHotelContext1 = _context.Review.Where(m => m.RoomID == id);
            ViewData["RoomID"] = id;
            return View(await vasaHotelContext1.ToListAsync());

        }
       
        // GET: Home/Create_review
        public IActionResult Create_review(int? id)
        {
            ViewData["RoomID"] = new SelectList(_context.Room, "room_id", id.ToString());
            return View();
        }

        // POST: Home/Create_review
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_review([Bind("review_id,Name,Day,Rating,Review_content,RoomID")] Review review, int? id)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomID"] = new SelectList(_context.Room, "room_id", id.ToString());
            return View(review);
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

        // GET: Customers/Create_customer
        public IActionResult Create_customer(int? id)
        {
            return View();
        }
        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_customer([Bind("customer_id,email,password,fullname,address,telephone,gender")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(customer);
                await _context.SaveChangesAsync();
                TempData["Customerid"] = _context.Customer.ToList().LastOrDefault().customer_id;
                return RedirectToAction(nameof(Create_booking));
            }
            return View(customer);
        }

        // GET: Bookings/Create_booking
        
        public IActionResult Create_booking()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customer, "customer_id", "customer_id");
            ViewData["RoomID"] = new SelectList(_context.Room, "room_id", "Name");
            ViewBag.Price = priceroom;
            return View();
        }

        // POST: Bookings/Create_booking
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_booking( [Bind("booking_id,checkout_day,checkin_day,method_payment,is_payment,CustomerID,RoomID,total_price")] Booking booking)
        {
          
            if (ModelState.IsValid)
            {
               
                var roomId = TempData["roomid"].ToString();
                var Customerid = TempData["Customerid"].ToString();
                booking = new Booking
                { checkout_day = booking.checkout_day,
                    checkin_day = booking.checkin_day,
                    method_payment = booking.method_payment,
                    is_payment = false,
                    RoomID = int.Parse(roomId),
                    CustomerID = int.Parse(Customerid),
                  total_price = priceroom,
                    // Set other prorties of the booking as needed
                };
             
                
                _context.Add(booking);
                await _context.SaveChangesAsync();
                bookingid = _context.Booking.ToList().LastOrDefault().booking_id;
                return RedirectToAction("Detail_booking", new { id = bookingid });
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "customer_id", "customer_id", booking.CustomerID);
            ViewData["RoomID"] = new SelectList(_context.Room, "room_id", "Name", booking.RoomID);
            ViewBag.Price = priceroom;
            return View(booking);
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Detail_booking(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .Include(b => b.Customer)
                .Include(b => b.Room)
                .FirstOrDefaultAsync(m => m.booking_id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }
    }
}
