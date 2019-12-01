using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Online_Store.Domain;
using Online_Store.Domain.Entities;

namespace Online_Store.UI.Controllers
{
    public class Category2EntityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Category2EntityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Category2Entity
        public async Task<IActionResult> Index()
        {
            return View(await _context.Category2s.ToListAsync());
        }

        // GET: Category2Entity/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category2Entity = await _context.Category2s
                .FirstOrDefaultAsync(m => m.Cat2ID == id);
            if (category2Entity == null)
            {
                return NotFound();
            }

            return View(category2Entity);
        }

        // GET: Category2Entity/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category2Entity/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cat2ID,Cat2Code,Cat2Desc,Cat2Img,Cat1ID,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,RowVersion")] Category2Entity category2Entity)
        {
            if (ModelState.IsValid)
            {
                category2Entity.Cat2ID = Guid.NewGuid();
                _context.Add(category2Entity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category2Entity);
        }

        // GET: Category2Entity/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category2Entity = await _context.Category2s.FindAsync(id);
            if (category2Entity == null)
            {
                return NotFound();
            }
            return View(category2Entity);
        }

        // POST: Category2Entity/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Cat2ID,Cat2Code,Cat2Desc,Cat2Img,Cat1ID,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,RowVersion")] Category2Entity category2Entity)
        {
            if (id != category2Entity.Cat2ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category2Entity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Category2EntityExists(category2Entity.Cat2ID))
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
            return View(category2Entity);
        }

        // GET: Category2Entity/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category2Entity = await _context.Category2s
                .FirstOrDefaultAsync(m => m.Cat2ID == id);
            if (category2Entity == null)
            {
                return NotFound();
            }

            return View(category2Entity);
        }

        // POST: Category2Entity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var category2Entity = await _context.Category2s.FindAsync(id);
            _context.Category2s.Remove(category2Entity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Category2EntityExists(Guid id)
        {
            return _context.Category2s.Any(e => e.Cat2ID == id);
        }
    }
}
