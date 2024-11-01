using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_Task.Models;
using X.PagedList;
using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Components.Forms;

namespace Group_Task.Controllers
{
    public class StockEntriesController : Controller
    {
        private readonly TestDbContext _context;

        public StockEntriesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: StockEntries
        public async Task<IActionResult> Index1()
        {
              return _context.StockEntries != null ? 
                          View(await _context.StockEntries.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.StockEntries'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.StockEntries select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.ReferenceNo != null && x.ReferenceNo.Contains(Empsearch)) ||                  
                    (x.Supplier != null && x.Supplier.Contains(Empsearch)) ||
                    (x.Descriptions != null && x.Descriptions.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }


        // GET: StockEntries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StockEntries == null)
            {
                return NotFound();
            }

            var stockEntry = await _context.StockEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stockEntry == null)
            {
                return NotFound();
            }

            return View(stockEntry);
        }

        // GET: StockEntries/Create
        public IActionResult Create()
        {
            return View();
        }
  
        // POST: StockEntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReferenceNo,TransactionDate,Supplier,Descriptions")] StockEntry stockEntry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stockEntry);
        }

        // GET: StockEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StockEntries == null)
            {
                return NotFound();
            }

            var stockEntry = await _context.StockEntries.FindAsync(id);
            if (stockEntry == null)
            {
                return NotFound();
            }
            return View(stockEntry);
        }

        // POST: StockEntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReferenceNo,TransactionDate,Supplier,Descriptions")] StockEntry stockEntry)
        {
            if (id != stockEntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockEntryExists(stockEntry.Id))
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
            return View(stockEntry);
        }

        // GET: StockEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StockEntries == null)
            {
                return NotFound();
            }

            var stockEntry = await _context.StockEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stockEntry == null)
            {
                return NotFound();
            }

            return View(stockEntry);
        }

        // POST: StockEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StockEntries == null)
            {
                return Problem("Entity set 'TestDbContext.StockEntries'  is null.");
            }
            var stockEntry = await _context.StockEntries.FindAsync(id);
            if (stockEntry != null)
            {
                _context.StockEntries.Remove(stockEntry);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockEntryExists(int id)
        {
          return (_context.StockEntries?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
