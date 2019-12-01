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
    public class UOMEntitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UOMEntitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UOMEntities
        public async Task<IActionResult> Index()
        {
            return View(await _context.UOMs.ToListAsync());
        }

        // GET: UOMEntities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uOMEntity = await _context.UOMs
                .FirstOrDefaultAsync(m => m.UOMID == id);
            if (uOMEntity == null)
            {
                return NotFound();
            }

            return View(uOMEntity);
        }

        // GET: UOMEntities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UOMEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UOMID,UOMCode,UOMDesc,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,RowVersion")] UOMEntity uOMEntity)
        {
            if (ModelState.IsValid)
            {
                uOMEntity.UOMID = Guid.NewGuid();
                _context.Add(uOMEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uOMEntity);
        }

        // GET: UOMEntities/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uOMEntity = await _context.UOMs.FindAsync(id);
            if (uOMEntity == null)
            {
                return NotFound();
            }
            return View(uOMEntity);
        }

        // POST: UOMEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("UOMID,UOMCode,UOMDesc,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate,RowVersion")] UOMEntity uOMEntity)
        {
            if (id != uOMEntity.UOMID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uOMEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UOMEntityExists(uOMEntity.UOMID))
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
            return View(uOMEntity);
        }

        // GET: UOMEntities/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uOMEntity = await _context.UOMs
                .FirstOrDefaultAsync(m => m.UOMID == id);
            if (uOMEntity == null)
            {
                return NotFound();
            }

            return View(uOMEntity);
        }

        // POST: UOMEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var uOMEntity = await _context.UOMs.FindAsync(id);
            _context.UOMs.Remove(uOMEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UOMEntityExists(Guid id)
        {
            return _context.UOMs.Any(e => e.UOMID == id);
        }
    }
}
