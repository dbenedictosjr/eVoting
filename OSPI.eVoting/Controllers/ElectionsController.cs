using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;

namespace OSPI.eVoting.Controllers
{
    public class ElectionsController : Controller
    {
        private readonly IElectionService _electionService;
        private readonly IPositionService _positionService;
        private readonly IMemberService _memberService;
        private readonly IBallotService _ballotService;
        private readonly IConfiguration _configuration;
        private readonly ICandidateService _candidateService;

        public ElectionsController(IElectionService electionService, IPositionService positionService, IMemberService memberService, IBallotService ballotService, IConfiguration configuration, ICandidateService candidateService)
        {
            _electionService = electionService;
            _positionService = positionService;
            _memberService = memberService;
            _ballotService = ballotService;
            _configuration = configuration;
            _candidateService = candidateService;
        }

        // GET: Elections
        public async Task<IActionResult> Election()
        {
            return View(await _positionService.GetByAllByBallotIdAsync(Guid.Parse(_configuration["BallotId"])));
        }

        // GET: Elections
        public async Task<IActionResult> Index() => View(await _positionService.GetAllAsync());

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

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Ballots"] = new SelectList(await _ballotService.GetAllAsync(), "BallotId", "Description");
            return View(election);
        }

        // GET: Elections/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Ballots"] = new SelectList(await _ballotService.GetAllAsync(), "BallotId", "Description");
            return View();
        }

        // POST: Elections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("electionId,Dateelectiond,MemberId,BallotId")] ElectionModel election)
        {
            if (ModelState.IsValid)
            {
                election.ElectionId = Guid.NewGuid();
                await _electionService.CreateAsync(election);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Ballots"] = new SelectList(await _ballotService.GetAllAsync(), "BallotId", "Description");
            return View(election);
        }

        // GET: Elections/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
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
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Ballots"] = new SelectList(await _ballotService.GetAllAsync(), "BallotId", "Description");
            return View(election);
        }

        // POST: Elections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("electionId,Dateelectiond,MemberId,BallotId,RowVersion")] ElectionModel election)
        {
            if (id != election.ElectionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _electionService.UpdateAsync(election);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Ballots"] = new SelectList(await _ballotService.GetAllAsync(), "BallotId", "Description");
            return View(election);
        }

        // GET: Elections/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
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

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Ballots"] = new SelectList(await _ballotService.GetAllAsync(), "BallotId", "Description");
            return View(election);
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

        public async Task<IActionResult> Test(string PositionId)
        {
            List<CandidateModel> List = new List<CandidateModel>();
            var rootpath = _configuration["RootMemberImagePath"];
            IEnumerable<CandidateModel> candidateModel = await _candidateService.GetAllByPositionIdAsync(Guid.Parse(PositionId), "Qualified");
            foreach (var item in candidateModel)
            {
                CandidateModel model = new CandidateModel();
                model.CandidateFirstName = item.CandidateFullName;
                string PNGfilePath = rootpath + "/" + item.CandidateMemberNo + "" + ".png";
                string JpgfilePath = rootpath + "/" + item.CandidateMemberNo + "" + ".jpg";
                if (System.IO.File.Exists(PNGfilePath))
                {

                    model.CandidateMemberNo = _configuration["MemberImagePath"] + "/" + item.CandidateMemberNo + "" + ".png";
                }
                else if (System.IO.File.Exists(JpgfilePath))
                {
                    model.CandidateMemberNo = _configuration["MemberImagePath"] + "/" + item.CandidateMemberNo + "" + ".jpg";
                }
                else
                {
                    model.CandidateMemberNo = _configuration["MemberImagePath"] + "/" + "default.png";
                }
                List.Add(model);
            }
            return Json(List);
        }
        public async Task<IActionResult> ElectionResult(string PositionId)
        {
            
            List<CandidateModel> List = new List<CandidateModel>();
            var rootpath = _configuration["RootMemberImagePath"];
            IEnumerable<CandidateModel> candidateModel = await _candidateService.GetAllAsync();
            foreach (var item in candidateModel)
            {
                CandidateModel model = new CandidateModel();
                model.CandidateFirstName = item.CandidateFullName;
                string PNGfilePath = rootpath + "/" + item.CandidateMemberNo + "" + ".png";
                string JpgfilePath = rootpath + "/" + item.CandidateMemberNo + "" + ".jpg";
                if (System.IO.File.Exists(PNGfilePath))
                {

                    model.CandidateMemberNo = _configuration["MemberImagePath"] + "/" + item.CandidateMemberNo + "" + ".png";
                }
                else if (System.IO.File.Exists(JpgfilePath))
                {
                    model.CandidateMemberNo = _configuration["MemberImagePath"] + "/" + item.CandidateMemberNo + "" + ".jpg";
                }
                else
                {
                    model.CandidateMemberNo = _configuration["MemberImagePath"] + "/" + "default.png";
                }
                List.Add(model);
            }
            return View(List);
        }
    }
}