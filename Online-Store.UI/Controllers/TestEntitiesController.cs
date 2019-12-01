using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Infrastructure.Interfaces;
using Online_Store.Infrastructure.Models;

namespace Online_Store.UI.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _TestService;

        public TestController(ITestService TestService) => this._TestService = TestService;

        // GET: Tests
        public async Task<IActionResult> Index() => View(await _TestService.GetAllAsync());

        // GET: Tests/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Test = await _TestService.GetByIDAsync(id);
            if (Test == null)
            {
                return NotFound();
            }

            return View(Test);
        }

        // GET: Test/Create
        public IActionResult Create() => View();

        // POST: Tests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Code,Description,Image")] TestModel Test)
        {
            if (ModelState.IsValid)
            {
                await _TestService.CreateAsync(Test);
                return RedirectToAction(nameof(Index));
            }
            return View(Test);
        }

        // GET: Tests/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Test = await _TestService.GetByIDAsync(id);
            if (Test == null)
            {
                return NotFound();
            }
            return View(Test);
        }

        // POST: Tests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Code,Description,RowVersion")] TestModel Test)
        {
            if (id != Test.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _TestService.UpdateAsync(Test);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Test);
        }

        // GET: Tests/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Test = await _TestService.GetByIDAsync(id);
            if (Test == null)
            {
                return NotFound();
            }

            return View(Test);
        }

        // POST: Tests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Test = await _TestService.GetByIDAsync(id);
            await _TestService.DeleteAsync(Test);
            return RedirectToAction(nameof(Index));
        }
    }
}