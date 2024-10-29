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
    public class MaterialTypesController : Controller
    {
        private readonly TestDbContext _context;

        public MaterialTypesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: MaterialTypes
        public async Task<IActionResult> Index1()
        {
              return _context.MaterialTypes != null ? 
                          View(await _context.MaterialTypes.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.MaterialTypes'  is null.");
        }

        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.MaterialTypes select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.MaterialName != null && x.MaterialName.Contains(Empsearch)) ||
                    (x.MaterialStatus != null && x.MaterialStatus.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }


        // GET: MaterialTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MaterialTypes == null)
            {
                return NotFound();
            }

            var materialType = await _context.MaterialTypes
                .FirstOrDefaultAsync(m => m.MaterialId == id);
            if (materialType == null)
            {
                return NotFound();
            }

            return View(materialType);
        }

        // GET: MaterialTypes/Create
        public IActionResult Create()
        {
            return View();
        }
        // code for download file
            public IActionResult Download()
            {
                // File name and path for saving to the desktop
                var fileName = "MaterialsList.csv";
                var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                // Generate CSV content for download using StringBuilder
                var csvContent = new StringBuilder();
                csvContent.AppendLine("Material Name,Material Status");

                // Retrieve the material data from the database
                var materials = GetMaterials();
                foreach (var material in materials)
                {
                    csvContent.AppendLine($"{material.MaterialName},{material.MaterialStatus}");
                }

                // Write the generated CSV content to a file on the desktop
                System.IO.File.WriteAllText(filePath, csvContent.ToString());

                // Read the file and return it as a downloadable file
                var fileBytes = System.IO.File.ReadAllBytes(filePath);
                return File(fileBytes, "text/csv", fileName);
            }

            // Method to get material data from the database
            private List<MaterialType> GetMaterials()
            {
                // Fetch only the MaterialName and MaterialStatus columns from the database
                return _context.MaterialTypes
                               .Select(m => new MaterialType
                               {
                                   MaterialName = m.MaterialName,
                                   MaterialStatus = m.MaterialStatus
                               })
                               .ToList();
            }
        
        // POST: MaterialTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaterialId,MaterialName,MaterialStatus")] MaterialType materialType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materialType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materialType);
        }

        // GET: MaterialTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MaterialTypes == null)
            {
                return NotFound();
            }

            var materialType = await _context.MaterialTypes.FindAsync(id);
            if (materialType == null)
            {
                return NotFound();
            }
            return View(materialType);
        }

        // POST: MaterialTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaterialId,MaterialName,MaterialStatus")] MaterialType materialType)
        {
            if (id != materialType.MaterialId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materialType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterialTypeExists(materialType.MaterialId))
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
            return View(materialType);
        }

        // GET: MaterialTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MaterialTypes == null)
            {
                return NotFound();
            }

            var materialType = await _context.MaterialTypes
                .FirstOrDefaultAsync(m => m.MaterialId == id);
            if (materialType == null)
            {
                return NotFound();
            }

            return View(materialType);
        }

        // POST: MaterialTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MaterialTypes == null)
            {
                return Problem("Entity set 'TestDbContext.MaterialTypes'  is null.");
            }
            var materialType = await _context.MaterialTypes.FindAsync(id);
            if (materialType != null)
            {
                _context.MaterialTypes.Remove(materialType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaterialTypeExists(int id)
        {
          return (_context.MaterialTypes?.Any(e => e.MaterialId == id)).GetValueOrDefault();
        }
    }
}
