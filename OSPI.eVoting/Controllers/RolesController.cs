using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class RolesController : Controller
    {
        private readonly IRoleService _RoleService;

        public RolesController(IRoleService RoleService) => _RoleService = RoleService;

        // GET: Roles
        public async Task<IActionResult> Index() => View(await _RoleService.GetAllAsync());

        // GET: Roles/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Role = await _RoleService.GetByIDAsync(id);
            if (Role == null)
            {
                return NotFound();
            }

            return View(Role);
        }

        // GET: Roles/Create
        public IActionResult Create() => View();

        // POST: Roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleID,RoleName,Description")] RoleModel Role)
        {
            if (ModelState.IsValid)
            {
                Role.RoleID = Guid.NewGuid();
                await _RoleService.CreateAsync(Role);
                return RedirectToAction(nameof(Index));
            }
            return View(Role);
        }

        // GET: Roles/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Role = await _RoleService.GetByIDAsync(id);
            if (Role == null)
            {
                return NotFound();
            }
            return View(Role);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("RoleID,RoleName,Description,RowVersion")] RoleModel Role)
        {
            if (id != Role.RoleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _RoleService.UpdateAsync(Role);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Role);
        }

        // GET: Roles/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Role = await _RoleService.GetByIDAsync(id);
            if (Role == null)
            {
                return NotFound();
            }

            return View(Role);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Role = await _RoleService.GetByIDAsync(id);
            await _RoleService.DeleteAsync(Role);
            return RedirectToAction(nameof(Index));
        }
    }
}