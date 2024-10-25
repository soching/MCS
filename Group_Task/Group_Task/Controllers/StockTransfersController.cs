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
    public class StockTransfersController : Controller
    {
        private readonly TestDbContext _context;

        public StockTransfersController(TestDbContext context)
        {
            _context = context;
        }

        // GET: StockTransfers
        public async Task<IActionResult> Index1()
        {
              return _context.StockTransfers != null ? 
                          View(await _context.StockTransfers.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.StockTransfers'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.StockTransfers select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.ReferenceNo != null && x.ReferenceNo.Contains(Empsearch)) ||
                    (x.Reference != null && x.Reference.Contains(Empsearch)) ||
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


        // GET: StockTransfers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StockTransfers == null)
            {
                return NotFound();
            }

            var stockTransfer = await _context.StockTransfers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stockTransfer == null)
            {
                return NotFound();
            }

            return View(stockTransfer);
        }

        // GET: StockTransfers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockTransfers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReferenceNo,TransactionDate,Reference,Descriptions")] StockTransfer stockTransfer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockTransfer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stockTransfer);
        }

        // GET: StockTransfers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StockTransfers == null)
            {
                return NotFound();
            }

            var stockTransfer = await _context.StockTransfers.FindAsync(id);
            if (stockTransfer == null)
            {
                return NotFound();
            }
            return View(stockTransfer);
        }

        // POST: StockTransfers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReferenceNo,TransactionDate,Reference,Descriptions")] StockTransfer stockTransfer)
        {
            if (id != stockTransfer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockTransfer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockTransferExists(stockTransfer.Id))
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
            return View(stockTransfer);
        }

        // GET: StockTransfers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StockTransfers == null)
            {
                return NotFound();
            }

            var stockTransfer = await _context.StockTransfers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stockTransfer == null)
            {
                return NotFound();
            }

            return View(stockTransfer);
        }

        // POST: StockTransfers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StockTransfers == null)
            {
                return Problem("Entity set 'TestDbContext.StockTransfers'  is null.");
            }
            var stockTransfer = await _context.StockTransfers.FindAsync(id);
            if (stockTransfer != null)
            {
                _context.StockTransfers.Remove(stockTransfer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockTransferExists(int id)
        {
          return (_context.StockTransfers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
