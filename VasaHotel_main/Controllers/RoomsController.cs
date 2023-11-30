using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VasaHotel.Models;
using VasaHotel_main.Areas.Identity.Data;
using Microsoft.AspNetCore.Http;


namespace VasaHotel_main.Controllers
{
    public class RoomsController : Controller
    {
        private readonly VasaHotelContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public RoomsController(VasaHotelContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Rooms
        public async Task<IActionResult> Index()
        {
            var vasaHotelContext = _context.Room.Include(r => r.Typeroom);
            return View(await vasaHotelContext.ToListAsync());
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Rooms/Create
        public IActionResult Create()
        {
            ViewData["TyperoomID"] = new SelectList(_context.Type_room, "type_room_id", "type_room_id");
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("room_id,TyperoomID,Name,Status,ImageName,Description")] Room room, IFormFile  uploadhinh)
        {
            _context.Add(room);
            await _context.SaveChangesAsync();
            if (ModelState.IsValid)
            {
                int id;
                var lastRoom = _context.Room.ToList().LastOrDefault();
                if (lastRoom != null)
                {
                    id = lastRoom.room_id;
                }
                else
                {
                    id = 0;
                }
               

            if (uploadhinh !=null && uploadhinh.Length > 0)
            {
                    string _Filename = "";
                 
                    int index = uploadhinh.FileName.IndexOf('.');
                    _Filename = "room" + id.ToString() + "." + uploadhinh.FileName.Substring(index + 1);
                    string path = Path.Combine(_hostEnvironment.WebRootPath, "Upload/Images", _Filename);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await uploadhinh.CopyToAsync(stream);
                    }
                    Room unv = _context.Room.FirstOrDefault(x => x.room_id == id);
                        if (unv != null)
                        {
                            unv.ImageName = _Filename;

                        }
                        await _context.SaveChangesAsync();

                   
            }

                
                return RedirectToAction(nameof(Index));
            }
            ViewData["TyperoomID"] = new SelectList(_context.Type_room, "type_room_id", "type_room_id", room.TyperoomID);
            return View(room);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            ViewData["TyperoomID"] = new SelectList(_context.Type_room, "type_room_id", "Name", room.TyperoomID);
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("room_id,TyperoomID,Name,Status,ImageName,Description")] Room room, IFormFile uploadhinh)
        {
            if (id != room.room_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (uploadhinh != null && uploadhinh.Length > 0)
                    {
                        int room_id = room.room_id;
                        id = room_id;
                        string _Filename = "";

                            int index = uploadhinh.FileName.IndexOf('.');
                            _Filename = "room" + id.ToString() + "." + uploadhinh.FileName.Substring(index + 1);
                            string path = Path.Combine(_hostEnvironment.WebRootPath, "Upload/Images", _Filename);
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await uploadhinh.CopyToAsync(stream);
                            }
                            room.ImageName = _Filename;
                        await _context.SaveChangesAsync();

                    }
                    else
                    {
                        // Retrieve existing image name from the database
                        var existingRoom = await _context.Room.FindAsync(id);
                        _context.Entry(existingRoom).State = EntityState.Detached; // Detach the existing entity
                        room.ImageName = existingRoom.ImageName;
                    }

                    _context.Update(room);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.room_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            ViewData["TyperoomID"] = new SelectList(_context.Type_room, "type_room_id", "Name", room.TyperoomID);
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _context.Room.FindAsync(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
            return _context.Room.Any(e => e.room_id == id);
        }
    }
}
