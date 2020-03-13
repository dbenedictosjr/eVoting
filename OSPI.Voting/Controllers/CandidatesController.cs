using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using System.Linq;
using OSPI.Voting.Helpers;

namespace OSPI.Voting.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ICandidateService _candidateService;
        private readonly IMemberService _memberService;
        private readonly IPositionService _positionService;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _emailSender;

        public CandidatesController(ICandidateService candidateService, IMemberService memberService, IPositionService positionService, IConfiguration configuration, IEmailSender emailSender)
        {
            _candidateService = candidateService;
            _memberService = memberService;
            _positionService = positionService;
            _configuration = configuration;
            _emailSender = emailSender;
        }

        // GET: Candidates
        public async Task<IActionResult> Index()
        {
            if(UserClaimsHelper.CanDoAction(User, "Nominations"+UserClaims.CanEdit))
                return View(await _candidateService.GetAllAsync());
            else
                return View(await _candidateService.GetAllByNomineeIdAsync(Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value)));
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

            ViewBag.UserID = Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value);
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

                //Send Email
                //var toAddress = "diego.benedictos.jr@gmail.com";
                //var subject = "Nominated for BOD";
                //var body = "You are nominated as a candidate for Board of Director";

                //_emailSender.Send(toAddress, subject, body);

                return RedirectToAction(nameof(Index));
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
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionId", "PositionName");
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
                    return RedirectToAction(nameof(Index));
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
            return RedirectToAction(nameof(Index));
        }
    }
}