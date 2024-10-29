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

        // code for download excel file
        public IActionResult Download()
        {
            // File name and path for saving to the desktop
            var fileName = "BoqWorkingType.csv";
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            // Generate CSV content for download using StringBuilder
            var csvContent = new StringBuilder();
            csvContent.AppendLine("BOQ No,Zone,Block, Building, House, Working Type, Amount, Transaction Date, Trans By, Trans Ref,Reference, BOQ Status, Revise Count ");

            // Retrieve the material data from the database
            var boqworkingtypes = GetBoqWorkingType();
            foreach (var boq in boqworkingtypes)
            {
                csvContent.AppendLine($"{boq.BoqNo},{boq.Zones},{boq.Blocks},{boq.Building},{boq.House},{boq.WorkingType},{boq.Amount},{boq.TransactionData},{boq.TransBy},{boq.TransRef},{boq.Reference},{boq.BoqStatus},{boq.ReviseCount}");
            }

            // Write the generated CSV content to a file on the desktop
            System.IO.File.WriteAllText(filePath, csvContent.ToString());

            // Read the file and return it as a downloadable file
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/csv", fileName);
        }

        // Method to get material data from the database
        private List<BoqWorkingType> GetBoqWorkingType()
        {
            // Fetch only the MaterialName and MaterialStatus columns from the database
            return _context.BoqWorkingTypes
                           .Select(b => new BoqWorkingType
                           {
                              BoqNo = b.BoqNo,
                              Zones = b.Zones,
                              Blocks = b.Blocks,
                              Building = b.Building,
                              House = b.House,
                              WorkingType = b.WorkingType,
                              Amount = b.Amount,
                              TransactionData = b.TransactionData,
                              TransBy = b.TransBy,
                              TransRef = b.TransRef,
                              Reference = b.Reference,
                              BoqStatus = b.BoqStatus,  
                              ReviseCount = b.ReviseCount
                           })
                           .ToList();
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
