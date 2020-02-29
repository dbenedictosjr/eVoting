using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class ElectionsController : Controller
    {
        private readonly IElectionService _electionService;
        private readonly IPositionService _positionService;

        public ElectionsController(IElectionService electionService, IPositionService positionService)
        {
            _electionService = electionService;
            _positionService = positionService;
        }

        // GET: Elections
        public async Task<IActionResult> Index() => View(await _electionService.GetAllAsync());

        // GET: Elections/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var election = await _electionService.GetByIdAsync(id);
            if (election == null)
            {
                return NotFound();
            }

            return View(election);
        }

        // GET: Elections/Create
        public IActionResult Create()
        {
            ElectionModel election = new ElectionModel
            {
                ElectionId = Guid.NewGuid(),
                RegStartDate = DateTime.Now,
                RegEndDate = DateTime.Now,
                VotingStartDate = DateTime.Now,
                VotingEndDate = DateTime.Now
            };

            return View(election);
        }

        // POST: Elections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Create([FromBody]ElectionModel election)
        {
            try
            {
                _electionService.CreateAsync(election);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }

        // GET: Elections/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var election = await _electionService.GetByIdAsync(id);
            //election.Positions = _positionService.GetAllAsync();
            if (election == null)
            {
                return NotFound();
            }
            return View(election);
        }

        // POST: Elections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Edit([FromBody]ElectionModel election)
        {
            try
            {
                _electionService.UpdateAsync(election);
                return Json(true);
            }
            catch (DbUpdateConcurrencyException)
            {
                ViewBag.Message = "Record has been modified by someone else.";
            }
            return Json(false);
        }

        // GET: Elections/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var election = await _positionService.GetByIdAsync(id);
            if (election == null)
            {
                return Json(false);
            }
            else
            {
              //  await _positionService.DeleteAsync(election);
            }

            return Json(true);
        }

        // POST: Elections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var election = await _electionService.GetByIdAsync(id);
            await _electionService.DeleteAsync(election);
            return RedirectToAction(nameof(Index));
        }
    }
}