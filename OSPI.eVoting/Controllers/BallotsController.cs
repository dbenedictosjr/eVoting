using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class BallotsController : Controller
    {
        private readonly IBallotService _BallotService;

        public BallotsController(IBallotService BallotService) => _BallotService = BallotService;

        // GET: Ballots
        public async Task<IActionResult> Index() => View(await _BallotService.GetAllAsync());

        // GET: Ballots/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Ballot = await _BallotService.GetByIDAsync(id);
            if (Ballot == null)
            {
                return NotFound();
            }

            return View(Ballot);
        }

        // GET: Ballots/Create
        public IActionResult Create() => View();

        // POST: Ballots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BallotID,RegStartDate,RegEndDate,VoteStartDate,VoteEndDate,PositionID")] BallotModel Ballot)
        {
            if (ModelState.IsValid)
            {
                Ballot.BallotID = Guid.NewGuid();
                await _BallotService.CreateAsync(Ballot);
                return RedirectToAction(nameof(Index));
            }
            return View(Ballot);
        }

        // GET: Ballots/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Ballot = await _BallotService.GetByIDAsync(id);
            if (Ballot == null)
            {
                return NotFound();
            }
            return View(Ballot);
        }

        // POST: Ballots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("BallotID,RegStartDate,RegEndDate,VoteStartDate,VoteEndDate,PositionID,RowVersion")] BallotModel Ballot)
        {
            if (id != Ballot.BallotID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _BallotService.UpdateAsync(Ballot);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Ballot);
        }

        // GET: Ballots/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Ballot = await _BallotService.GetByIDAsync(id);
            if (Ballot == null)
            {
                return NotFound();
            }

            return View(Ballot);
        }

        // POST: Ballots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Ballot = await _BallotService.GetByIDAsync(id);
            await _BallotService.DeleteAsync(Ballot);
            return RedirectToAction(nameof(Index));
        }
    }
}