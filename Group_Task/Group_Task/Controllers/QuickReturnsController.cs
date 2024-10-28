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
    public class QuickReturnsController : Controller
    {
        private readonly TestDbContext _context;

        public QuickReturnsController(TestDbContext context)
        {
            _context = context;
        }

        // GET: QuickReturns
        public async Task<IActionResult> Index1()
        {
              return _context.QuickReturns != null ? 
                          View(await _context.QuickReturns.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.QuickReturns'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.QuickReturns select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.ReferenceNo != null && x.ReferenceNo.Contains(Empsearch)) ||
                    (x.Reference != null && x.Reference.Contains(Empsearch)) ||
                    (x.Engineer != null && x.Engineer.Contains(Empsearch)) ||
                    (x.Subcontractor != null && x.Subcontractor.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }
        // GET: QuickReturns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.QuickReturns == null)
            {
                return NotFound();
            }

            var quickReturn = await _context.QuickReturns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quickReturn == null)
            {
                return NotFound();
            }

            return View(quickReturn);
        }

        // GET: QuickReturns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuickReturns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReferenceNo,TransactionDate,Reference,Engineer,Subcontractor,Descriptions")] QuickReturn quickReturn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quickReturn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quickReturn);
        }

        // GET: QuickReturns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.QuickReturns == null)
            {
                return NotFound();
            }

            var quickReturn = await _context.QuickReturns.FindAsync(id);
            if (quickReturn == null)
            {
                return NotFound();
            }
            return View(quickReturn);
        }

        // POST: QuickReturns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReferenceNo,TransactionDate,Reference,Engineer,Subcontractor,Descriptions")] QuickReturn quickReturn)
        {
            if (id != quickReturn.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quickReturn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuickReturnExists(quickReturn.Id))
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
            return View(quickReturn);
        }

        // GET: QuickReturns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.QuickReturns == null)
            {
                return NotFound();
            }

            var quickReturn = await _context.QuickReturns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (quickReturn == null)
            {
                return NotFound();
            }

            return View(quickReturn);
        }

        // POST: QuickReturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.QuickReturns == null)
            {
                return Problem("Entity set 'TestDbContext.QuickReturns'  is null.");
            }
            var quickReturn = await _context.QuickReturns.FindAsync(id);
            if (quickReturn != null)
            {
                _context.QuickReturns.Remove(quickReturn);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuickReturnExists(int id)
        {
          return (_context.QuickReturns?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
