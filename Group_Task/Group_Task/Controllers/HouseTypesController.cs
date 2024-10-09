using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group_Task.Models;


namespace Group_Task.Controllers
{
    public class HouseTypesController : Controller
    {
        private readonly TestDbContext _context;

        public HouseTypesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: HouseTypes
        public async Task<IActionResult> Index()
        {
              return _context.HouseTypes != null ? 
                          View(await _context.HouseTypes.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.HouseTypes'  is null.");
        }

        // GET: HouseTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HouseTypes == null)
            {
                return NotFound();
            }

            var houseType = await _context.HouseTypes
                .FirstOrDefaultAsync(m => m.HouseTypeId == id);
            if (houseType == null)
            {
                return NotFound();
            }

            return View(houseType);
        }

        // GET: HouseTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HouseTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HouseTypeId,HouseTypeName,Abbreviation,OrderNumber,StandardSize,Remark,HouseGroup,OtherCode,FormulaSide,FormulaMid")] HouseType houseType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(houseType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(houseType);
        }

        // GET: HouseTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HouseTypes == null)
            {
                return NotFound();
            }

            var houseType = await _context.HouseTypes.FindAsync(id);
            if (houseType == null)
            {
                return NotFound();
            }
            return View(houseType);
        }

        // POST: HouseTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HouseTypeId,HouseTypeName,Abbreviation,OrderNumber,StandardSize,Remark,HouseGroup,OtherCode,FormulaSide,FormulaMid")] HouseType houseType)
        {
            if (id != houseType.HouseTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(houseType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HouseTypeExists(houseType.HouseTypeId))
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
            return View(houseType);
        }

        // GET: HouseTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HouseTypes == null)
            {
                return NotFound();
            }

            var houseType = await _context.HouseTypes
                .FirstOrDefaultAsync(m => m.HouseTypeId == id);
            if (houseType == null)
            {
                return NotFound();
            }

            return View(houseType);
        }

        // POST: HouseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HouseTypes == null)
            {
                return Problem("Entity set 'TestDbContext.HouseTypes'  is null.");
            }
            var houseType = await _context.HouseTypes.FindAsync(id);
            if (houseType != null)
            {
                _context.HouseTypes.Remove(houseType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HouseTypeExists(int id)
        {
          return (_context.HouseTypes?.Any(e => e.HouseTypeId == id)).GetValueOrDefault();
        }
    }
}
