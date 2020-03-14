using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

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
            //if (member.Voted)
            //    return RedirectToAction("Results", "Elections");
            //else
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

        public async Task<IActionResult> Results(string id, string ButtonType)
        {
            List<CPositionModel> _result = new List<CPositionModel>();
            _result = await _electionService.GetAllPositionAsync(Guid.Parse(_configuration["BallotId"]), "Qualified");
            int i = _result.FindIndex(x => x.PositionId == id);
            if (ButtonType == null && i == -1)
            {
                i = 0;
            }
            else if (ButtonType.Trim() == ">")
            {
                i = (i < _result.Count - 1) ? i + 1 : 0;
            }
            else if (ButtonType.Trim() == "<")
            {
                i = i > 0 ? i - 1 : _result.Count - 1;
            }
            var _list = _result[i];
            List<string> canditateNameList = new List<string>();
            List<string> PercentageList = new List<string>();
            foreach (var item in _list.Candidates)
            {
                //var CandidateName = Regex.Replace(item.CandidateName, @"\s+", ""); 
                string CandidateName = Regex.Replace(item.CandidateName, " {2,}", " ");
                canditateNameList.Add(CandidateName);
                PercentageList.Add(item.Percentage);
            }
            //ViewData["canditateNameList"] = canditateNameList.ToArray();
            ViewBag.canditateNameList = JsonConvert.SerializeObject(canditateNameList.ToList());
            ViewBag.PercentageList = JsonConvert.SerializeObject(PercentageList.ToList());
            return View(_result[i]);
        }

    }
}