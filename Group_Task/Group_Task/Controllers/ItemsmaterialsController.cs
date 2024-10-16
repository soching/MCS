using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Group_Task.Models;


namespace Items_Material.Controllers
{
    public class ItemsmaterialsController : Controller
    {
        private readonly TestDbContext _context;

        public ItemsmaterialsController(TestDbContext context)
        {
            _context = context;
        }

        // GET: Itemsmaterials
        public async Task<IActionResult> Index1()
        {
              return _context.Itemsmaterials != null ? 
                          View(await _context.Itemsmaterials.ToListAsync()) :
                          Problem("Entity set 'Items_MaterialContext.Itemsmaterials'  is null.");
        }        
        public IActionResult AddNew()
        {
              return View();
        }
        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.Itemsmaterials select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.Groups != null && x.Groups.Contains(Empsearch)) ||
                    (x.Subgroup != null && x.Subgroup.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 5;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }

        // GET: Itemsmaterials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Itemsmaterials == null)
            {
                return NotFound();
            }

            var itemsmaterial = await _context.Itemsmaterials
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (itemsmaterial == null)
            {
                return NotFound();
            }

            return View(itemsmaterial);
        }

        // GET: Itemsmaterials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Itemsmaterials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,Groups,Subgroup,ItemCode,BrandCode,DescriptionKh,DescriptionEn,Brand,UomStock,Cost,Photo,Statuses,Itemtype,Materialtype,Actions")] Itemsmaterial itemsmaterial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemsmaterial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemsmaterial);
        }

        // GET: Itemsmaterials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Itemsmaterials == null)
            {
                return NotFound();
            }

            var itemsmaterial = await _context.Itemsmaterials.FindAsync(id);
            if (itemsmaterial == null)
            {
                return NotFound();
            }
            return View(itemsmaterial);
        }

        // POST: Itemsmaterials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,Groups,Subgroup,ItemCode,BrandCode,DescriptionKh,DescriptionEn,Brand,UomStock,Cost,Photo,Statuses,Itemtype,Materialtype,Actions")] Itemsmaterial itemsmaterial)
        {
            if (id != itemsmaterial.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemsmaterial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsmaterialExists(itemsmaterial.ItemId))
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
            return View(itemsmaterial);
        }

        // GET: Itemsmaterials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Itemsmaterials == null)
            {
                return NotFound();
            }

            var itemsmaterial = await _context.Itemsmaterials
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (itemsmaterial == null)
            {
                return NotFound();
            }

            return View(itemsmaterial);
        }

        // POST: Itemsmaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Itemsmaterials == null)
            {
                return Problem("Entity set 'Items_MaterialContext.Itemsmaterials'  is null.");
            }
            var itemsmaterial = await _context.Itemsmaterials.FindAsync(id);
            if (itemsmaterial != null)
            {
                _context.Itemsmaterials.Remove(itemsmaterial);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemsmaterialExists(int id)
        {
          return (_context.Itemsmaterials?.Any(e => e.ItemId == id)).GetValueOrDefault();
        }
    }
}
