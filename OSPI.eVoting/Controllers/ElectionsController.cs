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

        public ElectionsController(IElectionService electionService) => _electionService = electionService;

        // GET: Elections
        public async Task<IActionResult> Index() => View(await _electionService.GetAllAsync());

        // GET: Elections/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Election = await _electionService.GetByIDAsync(id);
            if (Election == null)
            {
                return NotFound();
            }

            return View(Election);
        }

        // GET: Elections/Create
        public IActionResult Create()
        {
            ElectionModel Election = new ElectionModel
            {
                ElectionID = Guid.NewGuid(),
                RegStartDate = DateTime.Now,
                RegEndDate = DateTime.Now,
                VotingStartDate = DateTime.Now,
                VotingEndDate = DateTime.Now
            };

            return View(Election);
        }

        // POST: Elections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Create([FromBody]ElectionModel election)
        {
            try
            {
                election.JournalID = Guid.NewGuid();
                var result = _cashReceiptJournalService.CreateAsync(election);
                if (result.Result == true)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
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

            var Election = await _electionService.GetByIDAsync(id);
            if (Election == null)
            {
                return NotFound();
            }
            return View(Election);
        }

        // POST: Elections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ElectionID,RefCode,Description,RegStartDate,RegEndDate,VotingStartDate,VotingEndDate,RowVersion")] ElectionModel election)
        {
            if (id != election.ElectionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _electionService.UpdateAsync(election);
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
                return RedirectToAction(nameof(Index));
            }
            return View(election);
        }

        // GET: Elections/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Election = await _electionService.GetByIDAsync(id);
            if (Election == null)
            {
                return NotFound();
            }

            return View(Election);
        }

        // POST: Elections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var election = await _electionService.GetByIDAsync(id);
            await _electionService.DeleteAsync(election);
            return RedirectToAction(nameof(Index));
        }
    }
}