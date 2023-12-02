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
    [Authorize]
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
        [AllowAnonymous]//allows access to action methods without authentication
        public async Task<IActionResult> Index()
        {
            var vasaHotelContext = _context.Room.Include(r => r.Typeroom).ToList();
            //query statement retrieves a list of rooms from the Room table and the room type by using the Include method
           // The query is converted to a list using the ToList() method and assigned to the `vasaHotelContext` variable.


            return View(vasaHotelContext);
        }


        static decimal priceroom { get; set; }//This static variable is used to store the room price
        static int bookingid { get; set; }//This static variable is used to store the booking ID

        // GET: Home/Detail_room/
        [AllowAnonymous]
        public async Task<IActionResult> Detail_room(int? id)
        {
            if (id == null) //If no id is passed, the method returns a 404 error
            {
                return NotFound();
            }
           
            var room = await _context.Room
                .Include(r => r.Typeroom)
                .FirstOrDefaultAsync(m => m.room_id == id);
            //Get room information including information about room type with corresponding ID from the database
            priceroom = room.Typeroom.Price; //assign the value of the Typeroom property to the priceroom variable
            TempData["roomid"] = room.room_id; //save the value of the room_id attribute of the room into TempData with the key "roomid"


            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }
        [AllowAnonymous]
        public IActionResult Contact()
        {
            return View();
        }

        // GET: Blog
        [AllowAnonymous]
        public async Task<IActionResult> Blog()

        {
            return View(await _context.Blog.ToListAsync());// //query statement retrieves a list of blogs from the Blog table
        }

        // GET: Blogs/Detail_blog/5
        [AllowAnonymous]
        public async Task<IActionResult> Detail_blog(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog
                .FirstOrDefaultAsync(m => m.blog_id == id);
            //Get blog information including information  with corresponding ID from the database
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }
        static int reviewid { get; set; }
        [AllowAnonymous]
        // GET: Home/Review_page
        public async Task<IActionResult> Review_page(int id)

        {
            reviewid = id;//assign the value of the `id` parameter to the `reviewid` variable
            var vasaHotelContext1 = _context.Review.Where(m => m.RoomID == id);
            //Query the database to get a list of reviews whose `RoomID` is equal to the `id` passed in

            return View(await vasaHotelContext1.ToListAsync());
            //returns a view, and the query data is passed to the view via the `ToListAsync()` method

        }

        // GET: Home/Create_review

        public IActionResult Create_review(int? id)
        {
            ViewData["RoomID"] = new SelectList(_context.Room, "room_id", id.ToString());
            ViewBag.Day = DateTime.Now;
            //The ViewBag.Day property is also set to the current date and time using DateTime.Now.
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
            {review = new Review // Creates a new Review object using data from the submitted form
            {    Name = review.Name,
                    Day = DateTime.Now, //Set the Day property of the new Review object to the current date and time using DateTime.Now.
                Rating = review.Rating,
                    Review_content = review.Review_content,
                    RoomID = reviewid,    
                };
                ViewBag.Day = review.Day;
                _context.Add(review); //It adds a new Review object to the _context using the Add method
                await _context.SaveChangesAsync();//Save changes to the database using the SaveChangesAsync method
                return RedirectToAction("Review_page", new { id = review.RoomID }); //redirect to action method "Review_page" with id parameter
            }   
            return View(review);
        }



        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
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
        static decimal totalPrice { get; set; }
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
                TimeSpan totalday = booking.checkout_day - booking.checkin_day;
                int numberOfDays = (int)totalday.TotalDays;
               totalPrice = priceroom * numberOfDays;
                booking = new Booking
                { checkout_day = booking.checkout_day,
                    checkin_day = booking.checkin_day,
                  
                    method_payment = "cash",
                    is_payment = false,
                    RoomID = int.Parse(roomId),
                    CustomerID = int.Parse(Customerid),
                  total_price = totalPrice,
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
