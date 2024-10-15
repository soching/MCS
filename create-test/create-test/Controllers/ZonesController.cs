using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using create_test.Data;
using create_test.Models;
using X.PagedList;

namespace create_test.Controllers
{
    public class ZonesController : Controller
    {
        private readonly create_testContext _context;

        public ZonesController(create_testContext context)
        {
            _context = context;
        }

        // GET: Zones
        public async Task<IActionResult> Index1()
        {
              return _context.Zones != null ? 
                          View(await _context.Zones.ToListAsync()) :
                          Problem("Entity set 'create_testContext.Zones'  is null.");
        }

        public ViewResult Index(int? page)
        {
            ViewData["Title"] = "Index";
            return View(_context.Zones.ToPagedList(page ?? 1, 5));
        }


        // GET: Zones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Zones == null)
            {
                return NotFound();
            }

            var zone = await _context.Zones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zone == null)
            {
                return NotFound();
            }

            return View(zone);
        }

        // GET: Zones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ZoneName,Status")] Zone zone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zone);
        }

        // GET: Zones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Zones == null)
            {
                return NotFound();
            }

            var zone = await _context.Zones.FindAsync(id);
            if (zone == null)
            {
                return NotFound();
            }
            return View(zone);
        }

        // POST: Zones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ZoneName,Status")] Zone zone)
        {
            if (id != zone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZoneExists(zone.Id))
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
            return View(zone);
        }

        // GET: Zones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Zones == null)
            {
                return NotFound();
            }

            var zone = await _context.Zones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zone == null)
            {
                return NotFound();
            }

            return View(zone);
        }

        // POST: Zones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Zones == null)
            {
                return Problem("Entity set 'create_testContext.Zones'  is null.");
            }
            var zone = await _context.Zones.FindAsync(id);
            if (zone != null)
            {
                _context.Zones.Remove(zone);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZoneExists(int id)
        {
          return (_context.Zones?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
