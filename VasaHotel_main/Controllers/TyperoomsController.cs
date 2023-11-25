using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VasaHotel.Models;
using VasaHotel_main.Areas.Identity.Data;

namespace VasaHotel_main.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TyperoomsController : Controller
    {
        private readonly VasaHotelContext _context;

        public TyperoomsController(VasaHotelContext context)
        {
            _context = context;
        }

        // GET: Typerooms
        public async Task<IActionResult> Index()
        {
            return View(await _context.Type_room.ToListAsync());
        }

        // GET: Typerooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeroom = await _context.Type_room
                .FirstOrDefaultAsync(m => m.type_room_id == id);
            if (typeroom == null)
            {
                return NotFound();
            }

            return View(typeroom);
        }

        // GET: Typerooms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Typerooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("type_room_id,Name,Price")] Typeroom typeroom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeroom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeroom);
        }

        // GET: Typerooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeroom = await _context.Type_room.FindAsync(id);
            if (typeroom == null)
            {
                return NotFound();
            }
            return View(typeroom);
        }

        // POST: Typerooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("type_room_id,Name,Price")] Typeroom typeroom)
        {
            if (id != typeroom.type_room_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeroom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TyperoomExists(typeroom.type_room_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(typeroom);
        }

        // GET: Typerooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeroom = await _context.Type_room
                .FirstOrDefaultAsync(m => m.type_room_id == id);
            if (typeroom == null)
            {
                return NotFound();
            }

            return View(typeroom);
        }

        // POST: Typerooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeroom = await _context.Type_room.FindAsync(id);
            _context.Type_room.Remove(typeroom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TyperoomExists(int id)
        {
            return _context.Type_room.Any(e => e.type_room_id == id);
        }
    }
}
