using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Group_Task.Models;
using System.Text;


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


        // code for download excel file
        public IActionResult Download()
        {
            // File name and path for saving to the desktop
            var fileName = "ItemMaterial.csv";
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            // Generate CSV content for download using StringBuilder
            var csvContent = new StringBuilder();
            csvContent.AppendLine("Group,Sub Group,Item Code, Description KH, Description EN, Brand, UOM Stock, Cost, Status, Item Type, Material Type");

            // Retrieve the material data from the database
            var itemmaterials = GetItemMaterials();
            foreach (var item in itemmaterials)
            {
                csvContent.AppendLine($"{item.Groups}, {item.Subgroup},{item.ItemCode},{item.DescriptionKh},{item.DescriptionEn},{item.Brand},{item.UomStock},{item.Cost},{item.Statuses},{item.Itemtype},{item.Materialtype}");
            }

            // Write the generated CSV content to a file on the desktop
            System.IO.File.WriteAllText(filePath, csvContent.ToString());

            // Read the file and return it as a downloadable file
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/csv", fileName);
        }

        // Method to get material data from the database
        private List<Itemsmaterial> GetItemMaterials()
        {
            // Fetch only the MaterialName and MaterialStatus columns from the database
            return _context.Itemsmaterials
                           .Select(m => new Itemsmaterial
                           {
                               Groups = m.Groups,
                               Subgroup = m.Subgroup,
                               ItemCode = m.ItemCode,
                               DescriptionKh = m.DescriptionKh,
                               DescriptionEn = m.DescriptionEn,
                               Brand = m.Brand,
                               UomStock = m.UomStock,
                               Cost = m.Cost,
                               Statuses = m.Statuses,
                               Itemtype = m.Itemtype,
                               Materialtype = m.Materialtype                        
                           })
                           .ToList();
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
