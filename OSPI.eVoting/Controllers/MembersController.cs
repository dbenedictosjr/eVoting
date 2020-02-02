using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Models;

namespace OSPI.eVoting.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IRoleService _roleService;

        public MembersController(IMemberService memberService, IRoleService roleService)
        {
            _memberService = memberService;
            _roleService = roleService;
        }

        // GET: Members
        public async Task<IActionResult> Index() => View(await _memberService.GetAllAsync());

        // GET: Members/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Member = await _memberService.GetByIDAsync(id);
            if (Member == null)
            {
                return NotFound();
            }

            return View(Member);
        }

        // GET: Members/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.MemberStatus = new[] { "Member", "Non Member" };
            ViewBag.CreditStatus = new[] { "Approved", "Disapproved" };
            ViewData["Roles"] = new SelectList(await _roleService.GetAllAsync(), "RoleID", "RoleName");
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberID,MemberNo,RegistrationDate,FirstName,MiddleName,LastName,HomeAddress,EmailAddress,PhoneNo,MobileNo,BirthDate,Capital,MemberStatus,CreditStatus,Password,DateHired,Salary,AccountNo,RoleID")] MemberModel Member)
        {
            if (ModelState.IsValid)
            {
                Member.MemberID = Guid.NewGuid();
                await _memberService.CreateAsync(Member);
                return RedirectToAction(nameof(Index));
            }
            return View(Member);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Member = await _memberService.GetByIDAsync(id);
            if (Member == null)
            {
                return NotFound();
            }
            return View(Member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("MemberID,MemberNo,RegistrationDate,FirstName,MiddleName,LastName,HomeAddress,EmailAddress,PhoneNo,MobileNo,BirthDate,Capital,MemberStatus,CreditStatus,Password,DateHired,Salary,AccountNo,RoleID,RowVersion")] MemberModel Member)
        {
            if (id != Member.MemberID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _memberService.UpdateAsync(Member);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            return View(Member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Member = await _memberService.GetByIDAsync(id);
            if (Member == null)
            {
                return NotFound();
            }

            return View(Member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Member = await _memberService.GetByIDAsync(id);
            await _memberService.DeleteAsync(Member);
            return RedirectToAction(nameof(Index));
        }
    }
}