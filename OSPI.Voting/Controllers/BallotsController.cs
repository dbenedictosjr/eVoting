using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.Voting.Controllers
{
    public class BallotsController : Controller
    {
        private readonly IBallotService _ballotService;
        private readonly IPositionService _positionService;

        public BallotsController(IBallotService ballotService, IPositionService positionService)
        {
            _ballotService = ballotService;
            _positionService = positionService;
        }

        // GET: Ballots
        public async Task<IActionResult> Index() => View(await _ballotService.GetAllAsync());

        // GET: Ballots/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ballot = await _ballotService.GetByIdAsync(id);
            if (ballot == null)
            {
                return NotFound();
            }

            return View(ballot);
        }

        // GET: Ballots/Create
        public IActionResult Create()
        {
            BallotModel ballot = new BallotModel
            {
                BallotId = Guid.NewGuid(),
                RegStartDate = DateTime.Now,
                RegEndDate = DateTime.Now,
                VotingStartDate = DateTime.Now,
                VotingEndDate = DateTime.Now
            };

            return View(ballot);
        }

        // POST: Ballots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Create([FromBody]BallotModel ballot)
        {
            try
            {
                ballot.BallotId = Guid.NewGuid();
                if (ballot != null)
                {
                    ballot.RegEndDate = Convert.ToDateTime(ballot.EditRegEndDate);
                    ballot.RegStartDate = Convert.ToDateTime(ballot.EditRegStartDate);
                    ballot.VotingStartDate = Convert.ToDateTime(ballot.EditVotingStartDate);
                    ballot.VotingEndDate = Convert.ToDateTime(ballot.EditVotingEndDate);
                }
                _ballotService.CreateAsync(ballot);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }

        // GET: Ballots/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ballot = await _ballotService.GetByIdAsync(id);
            if (ballot == null)
            {
                return NotFound();
            }
            return View(ballot);
        }

        // POST: Ballots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public JsonResult Edit([FromBody]BallotModel ballot)
        {
            try
            {
                if (ballot !=null)
                {
                    ballot.RegEndDate= Convert.ToDateTime(ballot.EditRegEndDate);
                    ballot.RegStartDate= Convert.ToDateTime(ballot.EditRegStartDate);
                    ballot.VotingStartDate= Convert.ToDateTime(ballot.EditVotingStartDate);
                    ballot.VotingEndDate= Convert.ToDateTime(ballot.EditVotingEndDate);
                }
                _ballotService.UpdateAsync(ballot);
                return Json(true);
            }
            catch (DbUpdateConcurrencyException)
            {
                ViewBag.Message = "Record has been modified by someone else.";
            }
            return Json(false);
        }

        // GET: Ballots/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ballot = await _positionService.GetByIdAsync(id);
            if (ballot == null)
            {
                return Json(false);
            }
            else
            {
                await _positionService.DeleteAsync(ballot);
            }

            return Json(true);
        }

        // POST: Ballots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var ballot = await _ballotService.GetByIdAsync(id);
            await _ballotService.DeleteAsync(ballot);
            return RedirectToAction(nameof(Index));
        }
    }
}