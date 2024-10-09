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
    public class TaskMastersController : Controller
    {
        private readonly TestDbContext _context;

        public TaskMastersController(TestDbContext context)
        {
            _context = context;
        }

        // GET: TaskMasters
        public async Task<IActionResult> Index()
        {
              return _context.TaskMasters != null ? 
                          View(await _context.TaskMasters.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.TaskMasters'  is null.");
        }

        // GET: TaskMasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TaskMasters == null)
            {
                return NotFound();
            }

            var taskMaster = await _context.TaskMasters
                .FirstOrDefaultAsync(m => m.TaskMasterId == id);
            if (taskMaster == null)
            {
                return NotFound();
            }

            return View(taskMaster);
        }

        // GET: TaskMasters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaskMasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskMasterId,TaskGroup,TaskCode,TaskName,Status,TaskType,Category,ReferenceNum,OldCode,OrderNo,FormularSide,FormularMiddle")] TaskMaster taskMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taskMaster);
        }

        // GET: TaskMasters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TaskMasters == null)
            {
                return NotFound();
            }

            var taskMaster = await _context.TaskMasters.FindAsync(id);
            if (taskMaster == null)
            {
                return NotFound();
            }
            return View(taskMaster);
        }

        // POST: TaskMasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskMasterId,TaskGroup,TaskCode,TaskName,Status,TaskType,Category,ReferenceNum,OldCode,OrderNo,FormularSide,FormularMiddle")] TaskMaster taskMaster)
        {
            if (id != taskMaster.TaskMasterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taskMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaskMasterExists(taskMaster.TaskMasterId))
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
            return View(taskMaster);
        }

        // GET: TaskMasters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TaskMasters == null)
            {
                return NotFound();
            }

            var taskMaster = await _context.TaskMasters
                .FirstOrDefaultAsync(m => m.TaskMasterId == id);
            if (taskMaster == null)
            {
                return NotFound();
            }

            return View(taskMaster);
        }

        // POST: TaskMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TaskMasters == null)
            {
                return Problem("Entity set 'TestDbContext.TaskMasters'  is null.");
            }
            var taskMaster = await _context.TaskMasters.FindAsync(id);
            if (taskMaster != null)
            {
                _context.TaskMasters.Remove(taskMaster);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaskMasterExists(int id)
        {
          return (_context.TaskMasters?.Any(e => e.TaskMasterId == id)).GetValueOrDefault();
        }
    }
}
