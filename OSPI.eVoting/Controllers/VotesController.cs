using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using Microsoft.Extensions.Configuration;

namespace OSPI.eVoting.Controllers
{
    public class VotesController : Controller
    {
        private readonly IVoteService _voteService;
        private readonly IPositionService _positionService;
        private readonly IMemberService _memberService;
        private readonly IElectionService _electionService;
        private readonly IConfiguration _configuration;

        public VotesController(IVoteService voteService, IPositionService positionService, IMemberService memberService, IElectionService electionService, IConfiguration configuration)
        {
            _voteService = voteService;
            _positionService = positionService;
            _memberService = memberService;
            _electionService = electionService;
            _configuration = configuration;
        }

        // GET: Votes
        public async Task<IActionResult> Vote()
        {
            return View(await _positionService.GetByAllByElectionIdAsync(Guid.Parse(_configuration["ElectionId"])));
        }

        // GET: Votes
        public async Task<IActionResult> Index() => View(await _voteService.GetAllAsync());

        // GET: Votes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vote = await _voteService.GetByIdAsync(id);
            if (vote == null)
            {
                return NotFound();
            }

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(vote);
        }

        // GET: Votes/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View();
        }

        // POST: Votes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("voteId,Datevoted,MemberId,ElectionId")] VoteModel vote)
        {
            if (ModelState.IsValid)
            {
                vote.VoteId = Guid.NewGuid();
                await _voteService.CreateAsync(vote);
                return RedirectToAction(nameof(Index));
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(vote);
        }

        // GET: Votes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vote = await _voteService.GetByIdAsync(id);
            if (vote == null)
            {
                return NotFound();
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(vote);
        }

        // POST: Votes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("voteId,Datevoted,MemberId,ElectionId,RowVersion")] VoteModel vote)
        {
            if (id != vote.VoteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _voteService.UpdateAsync(vote);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(vote);
        }

        // GET: Votes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vote = await _voteService.GetByIdAsync(id);
            if (vote == null)
            {
                return NotFound();
            }

            ViewData["Members"] = new SelectList(await _memberService.GetAllAsync(), "MemberId", "MemberFullName");
            ViewData["Elections"] = new SelectList(await _electionService.GetAllAsync(), "ElectionId", "Description");
            return View(vote);
        }

        // POST: Votes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var vote = await _voteService.GetByIdAsync(id);
            await _voteService.DeleteAsync(vote);
            return RedirectToAction(nameof(Index));
        }
    }
}