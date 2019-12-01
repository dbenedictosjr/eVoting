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
    public class Category3EntityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Category3EntityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Category3Entity
        public async Task<IActionResult> Index()
        {
            return View(await _context.Category3s.ToListAsync());
        }

        // GET: Category3Entity/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category3Entity = await _context.Category3s
                .FirstOrDefaultAsync(m => m.Cat3ID == id);
            if (category3Entity == null)
            {
                return NotFound();
            }

            return View(category3Entity);
        }

        // GET: Category3Entity/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category3Entity/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cat3ID,Cat3Code,Cat3Desc,Cat3Img,Cat2ID,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,RowVersion")] Category3Entity category3Entity)
        {
            if (ModelState.IsValid)
            {
                category3Entity.Cat3ID = Guid.NewGuid();
                _context.Add(category3Entity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category3Entity);
        }

        // GET: Category3Entity/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category3Entity = await _context.Category3s.FindAsync(id);
            if (category3Entity == null)
            {
                return NotFound();
            }
            return View(category3Entity);
        }

        // POST: Category3Entity/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Cat3ID,Cat3Code,Cat3Desc,Cat3Img,Cat2ID,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,RowVersion")] Category3Entity category3Entity)
        {
            if (id != category3Entity.Cat3ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category3Entity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Category3EntityExists(category3Entity.Cat3ID))
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
            return View(category3Entity);
        }

        // GET: Category3Entity/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category3Entity = await _context.Category3s
                .FirstOrDefaultAsync(m => m.Cat3ID == id);
            if (category3Entity == null)
            {
                return NotFound();
            }

            return View(category3Entity);
        }

        // POST: Category3Entity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var category3Entity = await _context.Category3s.FindAsync(id);
            _context.Category3s.Remove(category3Entity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Category3EntityExists(Guid id)
        {
            return _context.Category3s.Any(e => e.Cat3ID == id);
        }
    }
}
