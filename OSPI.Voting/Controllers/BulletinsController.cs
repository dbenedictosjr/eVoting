using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace OSPI.Voting.Controllers
{
    public class BulletinsController : Controller
    {
        private readonly IBulletinService _BulletinService;

        public BulletinsController(IBulletinService BulletinService)
        {
            _BulletinService = BulletinService;
        }

        // GET: Bulletins
        public async Task<IActionResult> Index() => View(await _BulletinService.GetAllAsync());

        // GET: Bulletins/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Bulletin = await _BulletinService.GetByIdAsync(id);
            if (Bulletin == null)
            {
                return NotFound();
            }

            return View(Bulletin);
        }

        // GET: Bulletins/Create
        public async Task<IActionResult> Create() => View();

        // POST: Bulletins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BulletinId,Title,Description")] BulletinModel Bulletin)
        {
            string fileName = string.Empty;
            string fileExt = string.Empty;

            if (ModelState.IsValid)
            {
                Bulletin.BulletinId = Guid.NewGuid();
                Bulletin.DatePosted = DateTime.Now;
                Bulletin.MemberId = Guid.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserGuid").Value);
                await _BulletinService.CreateAsync(Bulletin);
                return RedirectToAction(nameof(Index));
            }
            return View(Bulletin);
        }

        // GET: Bulletins/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Bulletin = await _BulletinService.GetByIdAsync(id);
            if (Bulletin == null)
            {
                return NotFound();
            }
            return View(Bulletin);
        }

        // POST: Bulletins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("BulletinId,Title,Description,RowVersion")] BulletinModel Bulletin)
        {
            if (id != Bulletin.BulletinId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _BulletinService.UpdateAsync(Bulletin);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Bulletin);
        }

        // GET: Bulletins/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Bulletin = await _BulletinService.GetByIdAsync(id);
            if (Bulletin == null)
            {
                return NotFound();
            }

            return View(Bulletin);
        }

        // POST: Bulletins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Bulletin = await _BulletinService.GetByIdAsync(id);
            await _BulletinService.DeleteAsync(Bulletin);
            return RedirectToAction(nameof(Index));
        }
    }
}