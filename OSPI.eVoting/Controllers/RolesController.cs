using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class RolesController : Controller
    {
        private readonly IRoleService _roleService;
        private readonly IModuleService _moduleService;

        public RolesController(IRoleService roleService, IModuleService moduleService)
        {
            _roleService = roleService;
            _moduleService = moduleService;
        }

        // GET: Roles
        public async Task<IActionResult> Index() => View(await _roleService.GetAllAsync());

        // GET: Roles/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleService.GetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        // GET: Roles/Create
        public async Task<IActionResult> Create()
        {
            RoleModel role = new RoleModel
            {
                RoleId = Guid.NewGuid(),
                RoleAccesses = new List<RoleAccessModel>()
            };

            IEnumerable<ModuleModel> modules = await _moduleService.GetAllAsync();

            foreach (ModuleModel module in modules)
            {
                role.RoleAccesses.Add(
                    new RoleAccessModel
                    {
                        RoleId = role.RoleId,
                        ModuleId = module.ModuleId,
                        ModuleName = module.ModuleName
                    }
                    );
            }

            return View(role);
        }

        // POST: Roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleId,RoleName,Description")] RoleModel role)
        {
            if (ModelState.IsValid)
            {
                role.RoleId = Guid.NewGuid();
                await _roleService.CreateAsync(role);
                return RedirectToAction(nameof(Index));
            }
            return View(role);
        }

        // GET: Roles/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleService.GetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            return View(role);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("RoleId,RoleName,Description,RowVersion")] RoleModel role)
        {
            if (id != role.RoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _roleService.UpdateAsync(role);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(role);
        }

        // GET: Roles/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleService.GetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var role = await _roleService.GetByIdAsync(id);
            await _roleService.DeleteAsync(role);
            return RedirectToAction(nameof(Index));
        }
    }
}