using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class ResultsController : Controller
    {
        private readonly IResultService _ResultService;

        public ResultsController(IResultService ResultService) => _ResultService = ResultService;

        // GET: Results
        public async Task<IActionResult> Index() => View(await _ResultService.GetAllAsync());

        // GET: Results/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Result = await _ResultService.GetByIDAsync(id);
            if (Result == null)
            {
                return NotFound();
            }

            return View(Result);
        }

        // GET: Results/Create
        public IActionResult Create() => View();

        // POST: Results/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResultID,MemberID,DateVoted")] ResultModel Result)
        {
            if (ModelState.IsValid)
            {
                Result.ResultID = Guid.NewGuid();
                await _ResultService.CreateAsync(Result);
                return RedirectToAction(nameof(Index));
            }
            return View(Result);
        }

        // GET: Results/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Result = await _ResultService.GetByIDAsync(id);
            if (Result == null)
            {
                return NotFound();
            }
            return View(Result);
        }

        // POST: Results/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ResultID,MemberID,DateVoted,RowVersion")] ResultModel Result)
        {
            if (id != Result.ResultID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _ResultService.UpdateAsync(Result);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Result);
        }

        // GET: Results/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Result = await _ResultService.GetByIDAsync(id);
            if (Result == null)
            {
                return NotFound();
            }

            return View(Result);
        }

        // POST: Results/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Result = await _ResultService.GetByIDAsync(id);
            await _ResultService.DeleteAsync(Result);
            return RedirectToAction(nameof(Index));
        }
    }
}