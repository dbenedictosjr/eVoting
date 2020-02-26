using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using System.Linq;

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
        public async Task<IActionResult> Index() => View(await _candidateService.GetAllByNomineeIdAsync(Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value)));

        // GET: Candidates/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _candidateService.GetByIdAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(candidate);
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
        public async Task<IActionResult> Create([Bind("CandidateID,CandidateMemberID,PositionID")] CandidateModel candidate)
        {
            if (ModelState.IsValid)
            {
                candidate.CandidateID = Guid.NewGuid();
                candidate.NomineeMemberID = Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value);
                candidate.Status = "For Approval";
                await _candidateService.CreateAsync(candidate);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(candidate);
        }

        // GET: Candidates/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _candidateService.GetByIdAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(candidate);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CandidateID,CandidateMemberID,PositionID,NomineeMemberID,Status,RowVersion")] CandidateModel candidate)
        {
            if (id != candidate.CandidateID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _candidateService.UpdateAsync(candidate);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(candidate);
        }

        // GET: Candidates/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _candidateService.GetByIdAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberID", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionID", "PositionName");
            return View(candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var candidate = await _candidateService.GetByIdAsync(id);
            await _candidateService.DeleteAsync(candidate);
            return RedirectToAction(nameof(Index));
        }
    }
}