using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class PositionsController : Controller
    {
        private readonly IPositionService _PositionService;

        public PositionsController(IPositionService PositionService) => _PositionService = PositionService;

        // GET: Positions
        public async Task<IActionResult> Index() => View(await _PositionService.GetAllAsync());

        // GET: Positions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Position = await _PositionService.GetByIDAsync(id);
            if (Position == null)
            {
                return NotFound();
            }

            return View(Position);
        }

        // GET: Positions/Create
        public IActionResult Create() => View();

        // POST: Positions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PositionID,Description,RequiredCandidates,Qualifications")] PositionModel Position)
        {
            if (ModelState.IsValid)
            {
                Position.PositionID = Guid.NewGuid();
                await _PositionService.CreateAsync(Position);
                return RedirectToAction(nameof(Index));
            }
            return View(Position);
        }

        // GET: Positions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Position = await _PositionService.GetByIDAsync(id);
            if (Position == null)
            {
                return NotFound();
            }
            return View(Position);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PositionID,Description,RequiredCandidates,Qualifications,RowVersion")] PositionModel Position)
        {
            if (id != Position.PositionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _PositionService.UpdateAsync(Position);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Position);
        }

        // GET: Positions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Position = await _PositionService.GetByIDAsync(id);
            if (Position == null)
            {
                return NotFound();
            }

            return View(Position);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Position = await _PositionService.GetByIDAsync(id);
            await _PositionService.DeleteAsync(Position);
            return RedirectToAction(nameof(Index));
        }
    }
}