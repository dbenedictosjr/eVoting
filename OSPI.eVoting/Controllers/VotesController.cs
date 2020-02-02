using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class VotesController : Controller
    {
        private readonly IVoteService _VoteService;

        public VotesController(IVoteService VoteService) => _VoteService = VoteService;

        // GET: Votes
        public async Task<IActionResult> Index() => View(await _VoteService.GetAllAsync());

        // GET: Votes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Vote = await _VoteService.GetByIDAsync(id);
            if (Vote == null)
            {
                return NotFound();
            }

            return View(Vote);
        }

        // GET: Votes/Create
        public IActionResult Create() => View();

        // POST: Votes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VoteID,CandidateID")] VoteModel Vote)
        {
            if (ModelState.IsValid)
            {
                Vote.VoteID = Guid.NewGuid();
                await _VoteService.CreateAsync(Vote);
                return RedirectToAction(nameof(Index));
            }
            return View(Vote);
        }

        // GET: Votes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Vote = await _VoteService.GetByIDAsync(id);
            if (Vote == null)
            {
                return NotFound();
            }
            return View(Vote);
        }

        // POST: Votes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("VoteID,CandidateID,RowVersion")] VoteModel Vote)
        {
            if (id != Vote.VoteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _VoteService.UpdateAsync(Vote);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Vote);
        }

        // GET: Votes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Vote = await _VoteService.GetByIDAsync(id);
            if (Vote == null)
            {
                return NotFound();
            }

            return View(Vote);
        }

        // POST: Votes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Vote = await _VoteService.GetByIDAsync(id);
            await _VoteService.DeleteAsync(Vote);
            return RedirectToAction(nameof(Index));
        }
    }
}