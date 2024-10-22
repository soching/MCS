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
    public class WorkingTypesController : Controller
    {
        private readonly TestDbContext _context;

        public WorkingTypesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: WorkingTypes
        public async Task<IActionResult> Index1()
        {
              return _context.WorkingTypes != null ? 
                          View(await _context.WorkingTypes.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.WorkingTypes'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.WorkingTypes select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.ProjectName != null && x.ProjectName.Contains(Empsearch)) ||
                    (x.Names != null && x.Names.Contains(Empsearch)) ||
                    (x.Parent != null && x.Parent.Contains(Empsearch)) ||
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

        // GET: WorkingTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.WorkingTypes == null)
            {
                return NotFound();
            }

            var workingType = await _context.WorkingTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workingType == null)
            {
                return NotFound();
            }

            return View(workingType);
        }

        // GET: WorkingTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WorkingTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectName,Names,Parent,Descriptions,CreateBy,WorkingtypeStatus")] WorkingType workingType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workingType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workingType);
        }

        // GET: WorkingTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.WorkingTypes == null)
            {
                return NotFound();
            }

            var workingType = await _context.WorkingTypes.FindAsync(id);
            if (workingType == null)
            {
                return NotFound();
            }
            return View(workingType);
        }

        // POST: WorkingTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectName,Names,Parent,Descriptions,CreateBy,WorkingtypeStatus")] WorkingType workingType)
        {
            if (id != workingType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workingType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkingTypeExists(workingType.Id))
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
            return View(workingType);
        }

        // GET: WorkingTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.WorkingTypes == null)
            {
                return NotFound();
            }

            var workingType = await _context.WorkingTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workingType == null)
            {
                return NotFound();
            }

            return View(workingType);
        }

        // POST: WorkingTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.WorkingTypes == null)
            {
                return Problem("Entity set 'TestDbContext.WorkingTypes'  is null.");
            }
            var workingType = await _context.WorkingTypes.FindAsync(id);
            if (workingType != null)
            {
                _context.WorkingTypes.Remove(workingType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkingTypeExists(int id)
        {
          return (_context.WorkingTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
