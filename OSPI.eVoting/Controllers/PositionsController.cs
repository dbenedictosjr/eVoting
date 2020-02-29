﻿using System;
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

            var position = await _positionService.GetByIdAsync(id);
            if (position == null)
            {
                return NotFound();
            }
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(position);
        }

        // GET: Positions/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View();
        }

        // POST: Positions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PositionId,PositionName,RequiredCandidates,Qualifications,ElectionId")] PositionModel position)
        {
            if (ModelState.IsValid)
            {
                position.PositionId = Guid.NewGuid();
                await _positionService.CreateAsync(position);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(position);
        }

        // GET: Positions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _positionService.GetByIdAsync(id);
            if (position == null)
            {
                return NotFound();
            }
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(position);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PositionId,PositionName,RequiredCandidates,Qualifications,ElectionId,RowVersion")] PositionModel position)
        {
            if (id != position.PositionId)
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
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(position);
        }

        // GET: Positions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var position = await _positionService.GetByIdAsync(id);
            if (position == null)
            {
                return NotFound();
            }

            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(position);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var position = await _positionService.GetByIdAsync(id);
            await _positionService.DeleteAsync(position);
            return RedirectToAction(nameof(Index));
        }
    }
}