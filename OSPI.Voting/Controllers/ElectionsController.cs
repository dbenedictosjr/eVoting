using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace OSPI.Voting.Controllers
{
    public class ElectionsController : Controller
    {
        private readonly IElectionService _electionService;
        private readonly IMemberService _memberService;
        private readonly IBallotService _ballotService;
        private readonly IConfiguration _configuration;
        private readonly ICandidateService _candidateService;

        public ElectionsController(IElectionService electionService, IMemberService memberService, IBallotService ballotService, IConfiguration configuration, ICandidateService candidateService)
        {
            _electionService = electionService;
            _memberService = memberService;
            _ballotService = ballotService;
            _configuration = configuration;
            _candidateService = candidateService;
        }

        // GET: Elections
        public async Task<IActionResult> Index()
        {
            MemberModel member = await _memberService.GetByIdAsync(Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value));
            if (member.Voted)
                return RedirectToAction("ElectionResult", "Elections");
            else
                return View(await _candidateService.GetAllPositionAsync(Guid.Parse(_configuration["BallotId"]), "Qualified"));
        }

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

        #region "Start Region for Save Election Data
        [HttpPost]
        public async Task< IActionResult> SaveVotes([FromBody] List<CPositionModel> data)
        {
            try
            {
                ElectionModel election = new ElectionModel
                {
                    ElectionId = Guid.NewGuid(),
                    DateVoted = DateTime.Now,
                    MemberId = Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value),
                    BallotId = Guid.Parse(_configuration["BallotId"])
                };
                await _electionService.SaveElection(election, data);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }
        #endregion "End Region of Save Election Data."
                
        public async Task<IActionResult> ElectionResult()
        {
            List<CandidateModel> List = new List<CandidateModel>();
            var rootpath = _configuration["RootMemberImagePath"];
            var result =await _memberService.GetAllVotersAsync();
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