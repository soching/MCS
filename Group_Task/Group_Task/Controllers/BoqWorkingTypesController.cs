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
    public class BoqWorkingTypesController : Controller
    {
        private readonly TestDbContext _context;

        public BoqWorkingTypesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: BoqWorkingTypes
        public async Task<IActionResult> Index1()
        {
              return _context.BoqWorkingTypes != null ? 
                          View(await _context.BoqWorkingTypes.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.BoqWorkingTypes'  is null.");
        }



        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.BoqWorkingTypes select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.BoqNo != null && x.BoqNo.Contains(Empsearch)) ||
                    (x.Blocks != null && x.Blocks.Contains(Empsearch)) ||
                    (x.Zones != null && x.Zones.Contains(Empsearch)) ||
                    (x.Building != null && x.Building.Contains(Empsearch)) ||
                    (x.Amount != null && x.Amount.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }


        public IActionResult AddNewBoq()
        {
            return View();
        }
        // GET: BoqWorkingTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BoqWorkingTypes == null)
            {
                return NotFound();
            }

            var boqWorkingType = await _context.BoqWorkingTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boqWorkingType == null)
            {
                return NotFound();
            }

            return View(boqWorkingType);
        }


        // GET: BoqWorkingTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BoqWorkingTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BoqNo,Zones,Blocks,Building,House,WorkingType,Amount,TransactionData,TransBy,TransRef,Reference,BoqStatus,ReviseCount")] BoqWorkingType boqWorkingType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boqWorkingType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boqWorkingType);
        }

        // GET: BoqWorkingTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BoqWorkingTypes == null)
            {
                return NotFound();
            }

            var boqWorkingType = await _context.BoqWorkingTypes.FindAsync(id);
            if (boqWorkingType == null)
            {
                return NotFound();
            }
            return View(boqWorkingType);
        }

        // POST: BoqWorkingTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BoqNo,Zones,Blocks,Building,House,WorkingType,Amount,TransactionData,TransBy,TransRef,Reference,BoqStatus,ReviseCount")] BoqWorkingType boqWorkingType)
        {
            if (id != boqWorkingType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boqWorkingType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoqWorkingTypeExists(boqWorkingType.Id))
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
            return View(boqWorkingType);
        }

        // GET: BoqWorkingTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BoqWorkingTypes == null)
            {
                return NotFound();
            }

            var boqWorkingType = await _context.BoqWorkingTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (boqWorkingType == null)
            {
                return NotFound();
            }

            return View(boqWorkingType);
        }

        // POST: BoqWorkingTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BoqWorkingTypes == null)
            {
                return Problem("Entity set 'TestDbContext.BoqWorkingTypes'  is null.");
            }
            var boqWorkingType = await _context.BoqWorkingTypes.FindAsync(id);
            if (boqWorkingType != null)
            {
                _context.BoqWorkingTypes.Remove(boqWorkingType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoqWorkingTypeExists(int id)
        {
          return (_context.BoqWorkingTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
