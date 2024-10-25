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
    public class GoodReceivedReturnsController : Controller
    {
        private readonly TestDbContext _context;

        public GoodReceivedReturnsController(TestDbContext context)
        {
            _context = context;
        }

        // GET: GoodReceivedReturns
        public async Task<IActionResult> Index1()
        {
              return _context.GoodReceivedReturns != null ? 
                          View(await _context.GoodReceivedReturns.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.GoodReceivedReturns'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.GoodReceivedReturns select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.ReferenceNo != null && x.ReferenceNo.Contains(Empsearch)) ||
                    (x.GrnNo != null && x.GrnNo.Contains(Empsearch)) ||
                    (x.Supplier != null && x.Supplier.Contains(Empsearch))                    
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }

        // GET: GoodReceivedReturns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GoodReceivedReturns == null)
            {
                return NotFound();
            }

            var goodReceivedReturn = await _context.GoodReceivedReturns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goodReceivedReturn == null)
            {
                return NotFound();
            }

            return View(goodReceivedReturn);
        }

        // GET: GoodReceivedReturns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GoodReceivedReturns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Photo,ReferenceNo,GrnNo,TransactionDate,Supplier,Descriptions,Warehouse,GrnDate,TransactionNo")] GoodReceivedReturn goodReceivedReturn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goodReceivedReturn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goodReceivedReturn);
        }

        // GET: GoodReceivedReturns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GoodReceivedReturns == null)
            {
                return NotFound();
            }

            var goodReceivedReturn = await _context.GoodReceivedReturns.FindAsync(id);
            if (goodReceivedReturn == null)
            {
                return NotFound();
            }
            return View(goodReceivedReturn);
        }

        // POST: GoodReceivedReturns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Photo,ReferenceNo,GrnNo,TransactionDate,Supplier,Descriptions,Warehouse,GrnDate,TransactionNo")] GoodReceivedReturn goodReceivedReturn)
        {
            if (id != goodReceivedReturn.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goodReceivedReturn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoodReceivedReturnExists(goodReceivedReturn.Id))
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
            return View(goodReceivedReturn);
        }

        // GET: GoodReceivedReturns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GoodReceivedReturns == null)
            {
                return NotFound();
            }

            var goodReceivedReturn = await _context.GoodReceivedReturns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goodReceivedReturn == null)
            {
                return NotFound();
            }

            return View(goodReceivedReturn);
        }

        // POST: GoodReceivedReturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GoodReceivedReturns == null)
            {
                return Problem("Entity set 'TestDbContext.GoodReceivedReturns'  is null.");
            }
            var goodReceivedReturn = await _context.GoodReceivedReturns.FindAsync(id);
            if (goodReceivedReturn != null)
            {
                _context.GoodReceivedReturns.Remove(goodReceivedReturn);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoodReceivedReturnExists(int id)
        {
          return (_context.GoodReceivedReturns?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
