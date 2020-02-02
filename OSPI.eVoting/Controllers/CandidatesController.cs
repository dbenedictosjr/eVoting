using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ICandidateService _CandidateService;

        public CandidatesController(ICandidateService CandidateService) => _CandidateService = CandidateService;

        // GET: Candidates
        public async Task<IActionResult> Index() => View(await _CandidateService.GetAllAsync());

        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Candidate = await _CandidateService.GetByIDAsync(id);
            if (Candidate == null)
            {
                return NotFound();
            }

            return View(Candidate);
        }

        // GET: Candidates/Create
        public IActionResult Create() => View();

        // POST: Candidates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CandidateID,CandidateMemberID,BallotID,NomineeMemberID,Status")] CandidateModel Candidate)
        {
            if (ModelState.IsValid)
            {
                Candidate.CandidateID = Guid.NewGuid();
                await _CandidateService.CreateAsync(Candidate);
                return RedirectToAction(nameof(Index));
            }
            return View(Candidate);
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Candidate = await _CandidateService.GetByIDAsync(id);
            if (Candidate == null)
            {
                return NotFound();
            }
            return View(Candidate);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CandidateID,CandidateMemberID,BallotID,NomineeMemberID,Status,RowVersion")] CandidateModel Candidate)
        {
            if (id != Candidate.CandidateID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _CandidateService.UpdateAsync(Candidate);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Candidate = await _CandidateService.GetByIDAsync(id);
            if (Candidate == null)
            {
                return NotFound();
            }

            return View(Candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Candidate = await _CandidateService.GetByIDAsync(id);
            await _CandidateService.DeleteAsync(Candidate);
            return RedirectToAction(nameof(Index));
        }
    }
}