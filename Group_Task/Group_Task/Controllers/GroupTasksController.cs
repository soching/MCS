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
    public class GroupTasksController : Controller
    {
        private readonly TestDbContext _context;

        public GroupTasksController(TestDbContext context)
        {
            _context = context;
        }

        // GET: GroupTasks
        public async Task<IActionResult> Index()
        {
            return _context.GroupTasks != null ?
                          View(await _context.GroupTasks.ToListAsync()) :
                          Problem("Entity set 'TestDbContext.GroupTasks '  is null.");

        }

        // GET: GroupTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GroupTasks == null)
            {
                return NotFound();
            }

            var groupTask = await _context.GroupTasks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (groupTask == null)
            {
                return NotFound();
            }

            return View(groupTask);
        }

        // GET: GroupTasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GroupTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TaskMasterId,TaskType,HouseId,GroupName")] GroupTask groupTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groupTask);
        }

        // GET: GroupTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GroupTasks == null)
            {
                return NotFound();
            }

            var groupTask = await _context.GroupTasks.FindAsync(id);
            if (groupTask == null)
            {
                return NotFound();
            }
            return View(groupTask);
        }

        // POST: GroupTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TaskMasterId,TaskType,HouseId,GroupName")] GroupTask groupTask)
        {
            if (id != groupTask.Id)
            {
               
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupTaskExists(groupTask.Id))
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
            return View(groupTask);
        }

        // GET: GroupTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GroupTasks == null)
            {
                return NotFound();
            }

            var groupTask = await _context.GroupTasks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (groupTask == null)
            {
                return NotFound();
            }

            return View(groupTask);
        }

        // POST: GroupTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GroupTasks == null)
            {
                return Problem("Entity set 'TestDbContext.GroupTasks'  is null.");
            }
            var groupTask = await _context.GroupTasks.FindAsync(id);
            if (groupTask != null)
            {
                _context.GroupTasks.Remove(groupTask);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupTaskExists(int id)
        {
          return (_context.GroupTasks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
