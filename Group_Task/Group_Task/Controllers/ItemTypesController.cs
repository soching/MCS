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
    public class ItemTypesController : Controller
    {
        private readonly TestDbContext _context;

        public ItemTypesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: ItemTypes
        public async Task<IActionResult> Index1()
        {
              return _context.ItemTypes != null ? 
                          View(await _context.ItemTypes.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.ItemTypes'  is null.");
        }
        public async Task<IActionResult> Index(string Empsearch, int? page)
        {
            ViewData["Getemployeedetails"] = Empsearch;
            ViewData["Title"] = "Index";

            // Define the base query from sql
            var empquery = from x in _context.ItemTypes select x;

            // Apply search filter if there's a search term
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x =>
                    (x.GroupName != null && x.GroupName.Contains(Empsearch)) ||
                    (x.SubOfCode != null && x.SubOfCode.Contains(Empsearch)) ||
                    (x.CompanyCode != null && x.CompanyCode.Contains(Empsearch)) ||
                    (x.GroupCode != null && x.GroupCode.Contains(Empsearch))
                );
            }

            // Set the page size
            int pageSize = 25;
            int pageNumber = page ?? 1; // If page is null, default to page 1

            // Convert query to paginated list
            var paginatedList = await empquery.AsNoTracking().ToPagedListAsync(pageNumber, pageSize);

            return View(paginatedList);
        }


        // GET: ItemTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ItemTypes == null)
            {
                return NotFound();
            }

            var itemType = await _context.ItemTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemType == null)
            {
                return NotFound();
            }

            return View(itemType);
        }

        // GET: ItemTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // code for download excel file
        public IActionResult Download()
        {
            // File name and path for saving to the desktop
            var fileName = "ItemType.csv";
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            // Generate CSV content for download using StringBuilder
            var csvContent = new StringBuilder();
            csvContent.AppendLine("Group Name,Group Code,Sub Of, Sub Of Code, Description, Company Code, Create By, Item Status");

            // Retrieve the material data from the database
            var itemtypes = GetItemType();
            foreach (var itemtype in itemtypes)
            {
                csvContent.AppendLine($"{itemtype.GroupName},{itemtype.GroupCode},{itemtype.SubOf},{itemtype.SubOfCode},{itemtype.Descriptions},{itemtype.CompanyCode},{itemtype.CreateBy},{itemtype.ItemStatus}");
            }

            // Write the generated CSV content to a file on the desktop
            System.IO.File.WriteAllText(filePath, csvContent.ToString());

            // Read the file and return it as a downloadable file
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/csv", fileName);
        }

        // Method to get material data from the database
        private List<ItemType> GetItemType()
        {
            // Fetch only the MaterialName and MaterialStatus columns from the database
            return _context.ItemTypes
                           .Select(i => new ItemType
                           {
                               GroupCode = i.GroupCode,
                               GroupName = i.GroupName,
                               SubOf = i.SubOf,
                               SubOfCode = i.SubOfCode,
                               Descriptions = i.Descriptions,
                               CompanyCode = i.CompanyCode,
                               CreateBy = i.CreateBy,
                               ItemStatus = i.ItemStatus
                           })
                           .ToList();
        }
        // POST: ItemTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GroupName,GroupCode,SubOf,SubOfCode,Descriptions,CompanyCode,CreateBy,ItemStatus")] ItemType itemType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemType);
        }

        // GET: ItemTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ItemTypes == null)
            {
                return NotFound();
            }

            var itemType = await _context.ItemTypes.FindAsync(id);
            if (itemType == null)
            {
                return NotFound();
            }
            return View(itemType);
        }

        // POST: ItemTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GroupName,GroupCode,SubOf,SubOfCode,Descriptions,CompanyCode,CreateBy,ItemStatus")] ItemType itemType)
        {
            if (id != itemType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemTypeExists(itemType.Id))
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
            return View(itemType);
        }

        // GET: ItemTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ItemTypes == null)
            {
                return NotFound();
            }

            var itemType = await _context.ItemTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemType == null)
            {
                return NotFound();
            }

            return View(itemType);
        }

        // POST: ItemTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ItemTypes == null)
            {
                return Problem("Entity set 'TestDbContext.ItemTypes'  is null.");
            }
            var itemType = await _context.ItemTypes.FindAsync(id);
            if (itemType != null)
            {
                _context.ItemTypes.Remove(itemType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemTypeExists(int id)
        {
          return (_context.ItemTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
