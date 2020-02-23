using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ICandidateService _candidateService;
        private readonly IMemberService _memberService;
        private readonly IPositionService _positionService;

        public CandidatesController(ICandidateService candidateService, IMemberService memberService, IPositionService positionService)
        {
            _candidateService = candidateService;
            _memberService = memberService;
            _positionService = positionService;
        }

        // GET: Candidates
        public async Task<IActionResult> Index() => View(await _candidateService.GetAllAsync());

        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Candidate = await _candidateService.GetByIDAsync(id);
            if (Candidate == null)
            {
                return NotFound();
            }

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(Candidate);
        }

        // GET: Candidates/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View();
        }

        // POST: Candidates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CandidateID,CandidateMemberID,PositionID,NomineeMemberID,Status")] CandidateModel Candidate)
        {
            if (ModelState.IsValid)
            {
                Candidate.CandidateID = Guid.NewGuid();
                await _candidateService.CreateAsync(Candidate);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(Candidate);
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Candidate = await _candidateService.GetByIDAsync(id);
            if (Candidate == null)
            {
                return NotFound();
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(Candidate);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CandidateID,CandidateMemberID,PositionID,NomineeMemberID,Status,RowVersion")] CandidateModel Candidate)
        {
            if (id != Candidate.CandidateID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _candidateService.UpdateAsync(Candidate);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(Candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Candidate = await _candidateService.GetByIDAsync(id);
            if (Candidate == null)
            {
                return NotFound();
            }

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(Candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Candidate = await _candidateService.GetByIDAsync(id);
            await _candidateService.DeleteAsync(Candidate);
            return RedirectToAction(nameof(Index));
        }
    }
}