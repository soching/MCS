using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P_Requests.Data;
using P_Requests.Models;
using X.PagedList;

namespace P_Requests.Controllers
{
    public class PurchaseRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseRequestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PurchaseRequests
        public IActionResult Index(int? page)
        {
            ViewData["Title"] = "Index";
            /*var PurchaseRequest = from p in _context.PurchaseRequests select p;
            var paginatedList = PurchaseRequest.ToPagedList(page ?? 1,4);*/
            //  return View(paginatedList);
          

            return View(_context.PurchaseRequests.ToPagedList(page ?? 1, 4));
        }

        // GET: PurchaseRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PurchaseRequests == null)
            {
                return NotFound();
            }

            var purchaseRequest = await _context.PurchaseRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchaseRequest == null)
            {
                return NotFound();
            }

            return View(purchaseRequest);
        }

        // GET: PurchaseRequests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PurchaseRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TransactionNo,TransactionDate,DeliveryDate,ApprovedDate,Department,Status,Note,RequestBy,UpdatedBy,CheckedBy,ApprovedBy,Attachment")] PurchaseRequest purchaseRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseRequest);
        }

        // GET: PurchaseRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PurchaseRequests == null)
            {
                return NotFound();
            }

            var purchaseRequest = await _context.PurchaseRequests.FindAsync(id);
            if (purchaseRequest == null)
            {
                return NotFound();
            }
            return View(purchaseRequest);
        }

        // POST: PurchaseRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TransactionNo,TransactionDate,DeliveryDate,ApprovedDate,Department,Status,Note,RequestBy,UpdatedBy,CheckedBy,ApprovedBy,Attachment")] PurchaseRequest purchaseRequest)
        {
            if (id != purchaseRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseRequestExists(purchaseRequest.Id))
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
            return View(purchaseRequest);
        }

        // GET: PurchaseRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PurchaseRequests == null)
            {
                return NotFound();
            }

            var purchaseRequest = await _context.PurchaseRequests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchaseRequest == null)
            {
                return NotFound();
            }

            return View(purchaseRequest);
        }

        // POST: PurchaseRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PurchaseRequests == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PurchaseRequests'  is null.");
            }
            var purchaseRequest = await _context.PurchaseRequests.FindAsync(id);
            if (purchaseRequest != null)
            {
                _context.PurchaseRequests.Remove(purchaseRequest);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseRequestExists(int id)
        {
          return (_context.PurchaseRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
