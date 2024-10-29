using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_Task.Models;
using X.PagedList;
using System.Text;

namespace Group_Task.Controllers
{
    public class SupplierItemsController : Controller
    {
        private readonly TestDbContext _context;

        public SupplierItemsController(TestDbContext context)
        {
            _context = context;
        }

        // GET: SupplierItems
        public async Task<IActionResult> Index1()
        {
              return _context.SupplierItems != null ? 
                          View(await _context.SupplierItems.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.SupplierItems'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.SupplierItems select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.Supplier != null && x.Supplier.Contains(Empsearch)) ||
                    (x.ItemMaterial != null && x.ItemMaterial.Contains(Empsearch)) ||
                    (x.Uom != null && x.Uom.Contains(Empsearch))                     
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }

        // GET: SupplierItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SupplierItems == null)
            {
                return NotFound();
            }

            var supplierItem = await _context.SupplierItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplierItem == null)
            {
                return NotFound();
            }

            return View(supplierItem);
        }

        // GET: SupplierItems/Create
        public IActionResult Create()
        {
            return View();
        }


        // code for download excel file
        public IActionResult Download()
        {
            // File name and path for saving to the desktop
            var fileName = "SupplierItem.csv";
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            // Generate CSV content for download using StringBuilder
            var csvContent = new StringBuilder();
            csvContent.AppendLine("Supplier,Item Material,UOM, Price, Supplier Status");

            // Retrieve the material data from the database
            var suppliers = GetSupplier();
            foreach (var supplier in suppliers)
            {
                csvContent.AppendLine($"{supplier.Supplier},{supplier.ItemMaterial},{supplier.Uom},{supplier.Price},{supplier.SupplierStatus}");
            }

            // Write the generated CSV content to a file on the desktop
            System.IO.File.WriteAllText(filePath, csvContent.ToString());

            // Read the file and return it as a downloadable file
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/csv", fileName);
        }

        // Method to get material data from the database
        private List<SupplierItem> GetSupplier()
        {
            // Fetch only the MaterialName and MaterialStatus columns from the database
            return _context.SupplierItems
                           .Select(s => new SupplierItem
                           {
                               Supplier = s.Supplier, 
                               ItemMaterial = s.ItemMaterial,
                               Uom = s.Uom,
                               Price = s.Price,
                               SupplierStatus = s.SupplierStatus
                           })
                           .ToList();
        }

        // POST: SupplierItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Supplier,ItemMaterial,Uom,Price,SupplierStatus")] SupplierItem supplierItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supplierItem);
        }

        // GET: SupplierItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SupplierItems == null)
            {
                return NotFound();
            }

            var supplierItem = await _context.SupplierItems.FindAsync(id);
            if (supplierItem == null)
            {
                return NotFound();
            }
            return View(supplierItem);
        }

        // POST: SupplierItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Supplier,ItemMaterial,Uom,Price,SupplierStatus")] SupplierItem supplierItem)
        {
            if (id != supplierItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierItemExists(supplierItem.Id))
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
            return View(supplierItem);
        }

        // GET: SupplierItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SupplierItems == null)
            {
                return NotFound();
            }

            var supplierItem = await _context.SupplierItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplierItem == null)
            {
                return NotFound();
            }

            return View(supplierItem);
        }

        // POST: SupplierItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SupplierItems == null)
            {
                return Problem("Entity set 'TestDbContext.SupplierItems'  is null.");
            }
            var supplierItem = await _context.SupplierItems.FindAsync(id);
            if (supplierItem != null)
            {
                _context.SupplierItems.Remove(supplierItem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierItemExists(int id)
        {
          return (_context.SupplierItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
