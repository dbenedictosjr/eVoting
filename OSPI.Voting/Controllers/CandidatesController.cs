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
        private readonly IBallotService _ballotService;
        private readonly IPositionService _positionService;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _emailSender;

        public CandidatesController(ICandidateService candidateService, IMemberService memberService, IBallotService ballotService, IPositionService positionService, IConfiguration configuration, IEmailSender emailSender)
        {
            _candidateService = candidateService;
            _memberService = memberService;
            _ballotService = ballotService;
            _positionService = positionService;
            _configuration = configuration;
            _emailSender = emailSender;
        }

        // GET: Candidates
        public async Task<IActionResult> Index()
        {
            BallotModel ballotModel = await _ballotService.GetByIdAsync(Guid.Parse(_configuration["BallotId"]));
            if (DateTime.Now > ballotModel.RegEndDate)
            {
                ViewBag.Message = "Nomination has ended.";
            }

            if (UserClaimsHelper.CanDoAction(User, "Nominations" + UserClaims.CanEdit))
                return View(await _candidateService.GetAllAsync());
            else
            {
                return View(await _candidateService.GetAllByNomineeIdAsync(Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value)));
            }
        }

        public async Task<IActionResult> Candidates()
        {
            BallotModel ballotModel = await _ballotService.GetByIdAsync(Guid.Parse(_configuration["BallotId"]));
            if (DateTime.Now < ballotModel.VotingStartDate)
            {
                ViewBag.Message = " Election will be held soon. Watch out for more information.";
            }

            if (DateTime.Now > ballotModel.VotingEndDate)
            {
                ViewBag.Message = "Election has ended.";
            }
            MemberModel member = await _memberService.GetByIdAsync(Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value));
            if (member.Voted)
            {
                ViewBag.Message = "This user has voted.";
            }
            return View(await _candidateService.GetAllCandidatesAsync(Guid.Parse(_configuration["BallotId"]), "Qualified"));
        }

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
            BallotModel ballotModel = await _ballotService.GetByIdAsync(Guid.Parse(_configuration["BallotId"]));
            if (ballotModel.RegStartDate >= DateTime.Now && ballotModel.RegEndDate <= DateTime.Now)
            {
                ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
                ViewData["Positions"] = new SelectList(await _positionService.GetAllAsync(), "PositionId", "PositionName");
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
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

                var memberDetails = await _memberService.GetByIdAsync(candidate.CandidateMemberId);
                var Positiondetails = await _positionService.GetByIdAsync(candidate.PositionId);
                if (memberDetails != null && Positiondetails != null)
                {
                    //Send Email
                    var toAddress = memberDetails.EmailAddress.Trim();
                    var subject = "Nominated for " + Positiondetails.PositionName.Trim();
                    string Url = _configuration["SiteUrl"] + "Candidates/Vericifation?id=" + candidate.CandidateId + "&Status=Accept";
                    string DeclineUrl = _configuration["SiteUrl"] + "Candidates/Vericifation?id=" + candidate.CandidateId + "&Status=Decline";
                    var body = "You have been nominated for the position of " + Positiondetails.PositionName.Trim() + " by " + User.Identity.Name.Trim();
                    body += "<br/ >Kindly select between the link below:";
                    body += "<br/>\n <a href = '" + Url + "'>Accept</a> if you wish to progress with the nomination.";
                    body += "<br/>\n <a href = '" + DeclineUrl + "'>Decline</a> if you feel that you are not ready for the position.";
                    _emailSender.Send(toAddress, subject, body);
                }

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

        // POST: Candidates/Delete/56
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var candidate = await _candidateService.GetByIdAsync(id);
            await _candidateService.DeleteAsync(candidate);
            return RedirectToAction(nameof(Index));
        }
 
        public async Task<IActionResult> Vericifation(Guid id,string Status)
        { 
            await _candidateService.UpdateStatusAsync(id, Status); 
            return RedirectToAction("StatusVericifation");
        }
        public async Task<IActionResult> StatusVericifation()
        {   
            return View();
        }
    }
}