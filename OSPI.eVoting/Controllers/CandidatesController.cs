using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace OSPI.eVoting.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ICandidateService _candidateService;
        private readonly IMemberService _memberService;
        private readonly IPositionService _positionService;
        private readonly IConfiguration _configuration;

        public CandidatesController(ICandidateService candidateService, IMemberService memberService, IPositionService positionService, IConfiguration configuration)
        {
            _candidateService = candidateService;
            _memberService = memberService;
            _positionService = positionService;
            _configuration = configuration;
        }

        // GET: Candidates
        public async Task<IActionResult> Index() => View(await _candidateService.GetAllAsync());

        public async Task<IActionResult> Nomination()
        {
            ViewBag.UserID = Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value);
            if (User.Claims.FirstOrDefault(x => x.Type == "Role").Value.ToUpper() == "82D0B260-E01D-4FB8-A4A6-4A6E0AB9E008")
                return View(await _candidateService.GetAllAsync());
            else
                return View(await _candidateService.GetAllByNomineeIdAsync(ViewBag.UserID));
        }

        public async Task<IActionResult> Candidates() => View(await _candidateService.GetAllCandidatesAsync(Guid.Parse(_configuration["BallotId"]), "Qualified"));

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

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionId", "PositionName");
            return View(candidate);
        }

        // GET: Candidates/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionId", "PositionName");
            return View();
        }

        // POST: Candidates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CandidateId,CandidateMemberId,PositionId")] CandidateModel candidate)
        {
            if (ModelState.IsValid)
            {
                candidate.CandidateId = Guid.NewGuid();
                candidate.NomineeMemberId = Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value);
                candidate.Status = "For Approval";
                await _candidateService.CreateAsync(candidate);
                return RedirectToAction(nameof(Nomination));
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionId", "PositionName");
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
            ViewBag.Status = new[] { "Qualified", "Not qualified" };
            return View(candidate);
        }

        // POST: Candidates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CandidateId,CandidateMemberId,PositionId,NomineeMemberId,Status,RowVersion")] CandidateModel candidate)
        {
            if (id != candidate.CandidateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _candidateService.UpdateAsync(candidate);
                    return RedirectToAction(nameof(Nomination));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewBag.Status = new[] { "Qualified", "Not qualified" };
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

            return View(candidate);
        }

        // POST: Candidates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var candidate = await _candidateService.GetByIdAsync(id);
            await _candidateService.DeleteAsync(candidate);
            return RedirectToAction(nameof(Nomination));
        }
    }
}