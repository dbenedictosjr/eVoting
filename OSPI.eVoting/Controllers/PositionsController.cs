using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class PositionsController : Controller
    {
        private readonly IPositionService _positionService;
        private readonly IElectionService _electionService;

        public PositionsController(IPositionService positionService, IElectionService electionService)
        {
            _positionService = positionService;
            _electionService = electionService;
        }

        // GET: Positions
        public async Task<IActionResult> Index() => View(await _positionService.GetAllAsync());

        // GET: Positions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Position = await _positionService.GetByIDAsync(id);
            if (Position == null)
            {
                return NotFound();
            }
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionID", "Description");
            return View(Position);
        }

        // GET: Positions/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionID", "Description");
            return View();
        }

        // POST: Positions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PositionID,PositionName,RequiredCandidates,Qualifications,ElectionID")] PositionModel position)
        {
            if (ModelState.IsValid)
            {
                position.PositionID = Guid.NewGuid();
                await _positionService.CreateAsync(position);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionID", "Description");
            return View(position);
        }

        // GET: Positions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Position = await _positionService.GetByIDAsync(id);
            if (Position == null)
            {
                return NotFound();
            }
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionID", "Description");
            return View(Position);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PositionID,PositionName,RequiredCandidates,Qualifications,ElectionID,RowVersion")] PositionModel position)
        {
            if (id != position.PositionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _positionService.UpdateAsync(position);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionID", "Description");
            return View(position);
        }

        // GET: Positions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Position = await _positionService.GetByIDAsync(id);
            if (Position == null)
            {
                return NotFound();
            }

            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionID", "Description");
            return View(Position);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var position = await _positionService.GetByIDAsync(id);
            await _positionService.DeleteAsync(position);
            return RedirectToAction(nameof(Index));
        }
    }
}