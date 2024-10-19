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
    public class SubcontractorsController : Controller
    {
        private readonly TestDbContext _context;

        public SubcontractorsController(TestDbContext context)
        {
            _context = context;
        }

        // GET: Subcontractors
        public async Task<IActionResult> Index1()
        {
              return _context.Subcontractors != null ? 
                          View(await _context.Subcontractors.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.Subcontractors'  is null.");
        }
        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.Subcontractors select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.ProjectName != null && x.ProjectName.Contains(Empsearch)) ||
                    (x.SubName != null && x.SubName.Contains(Empsearch)) ||
                    (x.IdCard != null && x.IdCard.Contains(Empsearch)) ||
                    (x.SubType != null && x.SubType.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }
        // GET: Subcontractors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Subcontractors == null)
            {
                return NotFound();
            }

            var subcontractor = await _context.Subcontractors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subcontractor == null)
            {
                return NotFound();
            }

            return View(subcontractor);
        }

        // GET: Subcontractors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subcontractors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectName,IdCard,SubName,Tel,SubAddress,SubType,SubStatus")] Subcontractor subcontractor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subcontractor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subcontractor);
        }

        // GET: Subcontractors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Subcontractors == null)
            {
                return NotFound();
            }

            var subcontractor = await _context.Subcontractors.FindAsync(id);
            if (subcontractor == null)
            {
                return NotFound();
            }
            return View(subcontractor);
        }

        // POST: Subcontractors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectName,IdCard,SubName,Tel,SubAddress,SubType,SubStatus")] Subcontractor subcontractor)
        {
            if (id != subcontractor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subcontractor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubcontractorExists(subcontractor.Id))
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
            return View(subcontractor);
        }

        // GET: Subcontractors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Subcontractors == null)
            {
                return NotFound();
            }

            var subcontractor = await _context.Subcontractors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subcontractor == null)
            {
                return NotFound();
            }

            return View(subcontractor);
        }

        // POST: Subcontractors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Subcontractors == null)
            {
                return Problem("Entity set 'TestDbContext.Subcontractors'  is null.");
            }
            var subcontractor = await _context.Subcontractors.FindAsync(id);
            if (subcontractor != null)
            {
                _context.Subcontractors.Remove(subcontractor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubcontractorExists(int id)
        {
          return (_context.Subcontractors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
