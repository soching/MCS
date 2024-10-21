using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_Task.Models;
using X.PagedList;

namespace Group_Task.Controllers
{
    public class BlocksController : Controller
    {
        private readonly TestDbContext _context;

        public BlocksController(TestDbContext context)
        {
            _context = context;
        }

        // GET: Blocks
        public async Task<IActionResult> Index1()
        {
              return _context.Blocks != null ? 
                          View(await _context.Blocks.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.Blocks'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.Blocks select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.ProjectName != null && x.ProjectName.Contains(Empsearch)) ||
                    (x.Names != null && x.Names.Contains(Empsearch)) ||
                    (x.Zones != null && x.Zones.Contains(Empsearch)) ||
                    (x.CreateBy != null && x.CreateBy.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }
        // GET: Blocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Blocks == null)
            {
                return NotFound();
            }

            var block = await _context.Blocks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (block == null)
            {
                return NotFound();
            }

            return View(block);
        }

        // GET: Blocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectName,Names,Zones,Descriptions,CreateBy,BlockStatus")] Block block)
        {
            if (ModelState.IsValid)
            {
                _context.Add(block);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(block);
        }

        // GET: Blocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Blocks == null)
            {
                return NotFound();
            }

            var block = await _context.Blocks.FindAsync(id);
            if (block == null)
            {
                return NotFound();
            }
            return View(block);
        }

        // POST: Blocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectName,Names,Zones,Descriptions,CreateBy,BlockStatus")] Block block)
        {
            if (id != block.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(block);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlockExists(block.Id))
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
            return View(block);
        }

        // GET: Blocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Blocks == null)
            {
                return NotFound();
            }

            var block = await _context.Blocks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (block == null)
            {
                return NotFound();
            }

            return View(block);
        }

        // POST: Blocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Blocks == null)
            {
                return Problem("Entity set 'TestDbContext.Blocks'  is null.");
            }
            var block = await _context.Blocks.FindAsync(id);
            if (block != null)
            {
                _context.Blocks.Remove(block);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlockExists(int id)
        {
          return (_context.Blocks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
