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
    public class BoqDetailsController : Controller
    {
        private readonly TestDbContext _context;

        public BoqDetailsController(TestDbContext context)
        {
            _context = context;
        }

        // GET: BoqDetails
        public async Task<IActionResult> Index1()
        {
              return _context.BoqDetails != null ? 
                          View(await _context.BoqDetails.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.BoqDetails'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.BoqDetails select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.BoqNo != null && x.BoqNo.Contains(Empsearch)) ||
                    (x.Blocks != null && x.Blocks.Contains(Empsearch)) ||
                    (x.Building != null && x.Building.Contains(Empsearch)) ||
                    (x.Brand != null && x.Brand.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }

        // GET: BoqDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BoqDetails == null)
            {
                return NotFound();
            }

            var boqDetail = await _context.BoqDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boqDetail == null)
            {
                return NotFound();
            }

            return View(boqDetail);
        }

        // GET: BoqDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BoqDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BoqNo,Project,Zones,Blocks,Building,HouseNo,HouseType,MainWorkingType,WorkingType,ItemCode,DescriptionKh,DescriptionEn,Brand,BoqQty,AdditionalQty,Uom")] BoqDetail boqDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boqDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boqDetail);
        }

        // GET: BoqDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BoqDetails == null)
            {
                return NotFound();
            }

            var boqDetail = await _context.BoqDetails.FindAsync(id);
            if (boqDetail == null)
            {
                return NotFound();
            }
            return View(boqDetail);
        }

        // POST: BoqDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BoqNo,Project,Zones,Blocks,Building,HouseNo,HouseType,MainWorkingType,WorkingType,ItemCode,DescriptionKh,DescriptionEn,Brand,BoqQty,AdditionalQty,Uom")] BoqDetail boqDetail)
        {
            if (id != boqDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boqDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoqDetailExists(boqDetail.Id))
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
            return View(boqDetail);
        }

        // GET: BoqDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BoqDetails == null)
            {
                return NotFound();
            }

            var boqDetail = await _context.BoqDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boqDetail == null)
            {
                return NotFound();
            }

            return View(boqDetail);
        }

        // POST: BoqDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BoqDetails == null)
            {
                return Problem("Entity set 'TestDbContext.BoqDetails'  is null.");
            }
            var boqDetail = await _context.BoqDetails.FindAsync(id);
            if (boqDetail != null)
            {
                _context.BoqDetails.Remove(boqDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoqDetailExists(int id)
        {
          return (_context.BoqDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
