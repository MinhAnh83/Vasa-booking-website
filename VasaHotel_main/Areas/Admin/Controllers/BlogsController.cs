using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VasaHotel.Models;
using VasaHotel_main.Areas.Identity.Data;

namespace VasaHotel_main.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Staff, Admin")]
    public class BlogsController : Controller
    {
        private readonly VasaHotelContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public BlogsController(VasaHotelContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Blogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blog.ToListAsync());
        }

        // GET: Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("blog_id,author_name,day_published,Title,Content,Images")] Blog blog, List<IFormFile> uploadhinh)
        {
            _context.Add(blog);
            await _context.SaveChangesAsync();
            if (ModelState.IsValid)
            {
                int id;
                var lastBlog = _context.Blog.ToList().LastOrDefault();
                if (lastBlog != null)
                {
                    id = lastBlog.blog_id;
                }
                else
                {
                    id = 0;
                }


                if (uploadhinh != null && uploadhinh.Count > 0)
                {
                    string _Filename = "";
                    foreach (var file in uploadhinh)
                    {
                        int index = file.FileName.IndexOf('.');
                        _Filename = "blog" + id.ToString() + "." + file.FileName.Substring(index + 1);
                        string path = Path.Combine(_hostEnvironment.WebRootPath, "Upload/Images", _Filename);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        Blog unv = _context.Blog.FirstOrDefault(x => x.blog_id == id);
                        if (unv != null)
                        {
                            unv.Images = _Filename;

                        }
                        await _context.SaveChangesAsync();

                    }
                }


                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("blog_id,author_name,day_published,Title,Content,Images")] Blog blog, List<IFormFile> uploadhinh)
        {
            if (id != blog.blog_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                    if (uploadhinh != null && uploadhinh.Count > 0)
                    {
                        string _Filename = "";
                        foreach (var file in uploadhinh)
                        {
                            int index = file.FileName.IndexOf('.');
                            _Filename = "blog" + id.ToString() + "." + file.FileName.Substring(index + 1);
                            string path = Path.Combine(_hostEnvironment.WebRootPath, "Upload/Images", _Filename);

                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await file.CopyToAsync(stream);
                            }
                            Blog unv = _context.Blog.FirstOrDefault(x => x.blog_id == id);
                            if (unv != null)
                            {
                                unv.Images = _Filename;

                            }
                            await _context.SaveChangesAsync();

                        }
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.blog_id))
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
            return View(blog);
        }

        // GET: Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blog.FindAsync(id);
            _context.Blog.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            return _context.Blog.Any(e => e.blog_id == id);
        }
    }
}
