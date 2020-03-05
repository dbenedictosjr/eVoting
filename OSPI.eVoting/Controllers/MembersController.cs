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

namespace OSPI.eVoting.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IRoleService _roleService;
        private readonly IRoleAccessService _roleAccessService;

        public MembersController(IMemberService memberService, IRoleService roleService, IRoleAccessService roleAccessService)
        {
            _memberService = memberService;
            _roleService = roleService;
            _roleAccessService = roleAccessService;
        }

        // GET: Members
        public async Task<IActionResult> Index() => View(await _memberService.GetAllAsync());

        // GET: Members
        public async Task<IActionResult> Voters() => View(await _memberService.GetAllVotersAsync());

        // GET: Members/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _memberService.GetByIdAsync(id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: Members/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.MemberStatus = new[] { "Member", "Non Member" };
            ViewBag.CreditStatus = new[] { "Approved", "Disapproved" };
            ViewData["Roles"] = new SelectList(await _roleService.GetAllAsync(), "RoleId", "RoleName");
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberId,MemberNo,RegistrationDate,FirstName,MiddleName,LastName,HomeAddress,EmailAddress,PhoneNo,MobileNo,BirthDate,Capital,MemberStatus,CreditStatus,Password,DateHired,Salary,AccountNo,RoleId")] MemberModel member, IFormFile file)
        {
            string fileName = string.Empty;
            string fileExt = string.Empty;

            if (ModelState.IsValid)
            {
                member.MemberId = Guid.NewGuid();
                await _memberService.CreateAsync(member);
                #region "File Upload"
                if (file != null || file.Length > 0)
                {
                    fileExt = Path.GetExtension(file.FileName);
                    fileName = member.MemberNo + "" + fileExt;


                }
                var rootpath = "wwwroot/images/MemberImage";
                var path = Path.Combine(
                 Directory.GetCurrentDirectory(), rootpath, fileName);
                if (!(Directory.Exists(rootpath)))
                {
                    Directory.CreateDirectory(rootpath);
                }
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                #endregion "End File Upload"
                return RedirectToAction(nameof(Index));
            }
            ViewBag.MemberStatus = new[] { "Member", "Non Member" };
            ViewBag.CreditStatus = new[] { "Approved", "Disapproved" };
            ViewData["Roles"] = new SelectList(await _roleService.GetAllAsync(), "RoleId", "RoleName");
            return View(member);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["Roles"] = new SelectList(await _roleService.GetAllAsync(), "RoleId", "RoleName");
            var member = await _memberService.GetByIdAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            ViewBag.MemberStatus = new[] { "Member", "Non Member" };
            ViewBag.CreditStatus = new[] { "Approved", "Disapproved" };
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("MemberId,MemberNo,RegistrationDate,FirstName,MiddleName,LastName,HomeAddress,EmailAddress,PhoneNo,MobileNo,BirthDate,Capital,MemberStatus,CreditStatus,Password,DateHired,Salary,AccountNo,RoleId,RowVersion")] MemberModel member)
        {
            if (id != member.MemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _memberService.UpdateAsync(member);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    ViewBag.Message = "Record has been modified by someone else.";
                }
            }
            ViewBag.MemberStatus = new[] { "Member", "Non Member" };
            ViewBag.CreditStatus = new[] { "Approved", "Disapproved" };
            ViewData["Roles"] = new SelectList(await _roleService.GetAllAsync(), "RoleId", "RoleName");
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _memberService.GetByIdAsync(id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var member = await _memberService.GetByIdAsync(id);
            await _memberService.DeleteAsync(member);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LogInModel model)
        {
            var member = await _memberService.GetByCodeAsync(model.MemberNo);

            if (member == null || member.Password.Trim() != model.Password.Trim())
            {
                ModelState.AddModelError("", "Member not found");
                model.Password = "";
                return View(model);
            }

            var roleAccesses = (await _roleAccessService.GetAllByRoleIdAsync(member.RoleId));

            if (roleAccesses == null)
            {
                ModelState.AddModelError("", "Member not found");
                model.Password = "";
                return View(model);
            }

            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

            identity.AddClaim(new Claim(UserClaims.UserGuid, member.MemberId.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.Name, member.MemberFullName));
            identity.AddClaim(new Claim(UserClaims.Role, member.RoleId.ToString()));

            foreach (RoleAccessModel roleAccess in roleAccesses)
            {
                if (roleAccess.CanAdd) identity.AddClaim(new Claim(roleAccess.ModuleName + UserClaims.CanAdd, roleAccess.CanAdd.ToString()));
                if (roleAccess.CanView) identity.AddClaim(new Claim(roleAccess.ModuleName + UserClaims.CanView, roleAccess.CanView.ToString()));
                if (roleAccess.CanEdit) identity.AddClaim(new Claim(roleAccess.ModuleName + UserClaims.CanEdit, roleAccess.CanEdit.ToString()));
                if (roleAccess.CanDelete) identity.AddClaim(new Claim(roleAccess.ModuleName + UserClaims.CanDelete, roleAccess.CanDelete.ToString()));
                if (roleAccess.CanPrint) identity.AddClaim(new Claim(roleAccess.ModuleName + UserClaims.CanPrint, roleAccess.CanEdit.ToString()));
            }

            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("Index", "Members");
        }

        public  IActionResult Setting()
        {
            return View();
        }
    }
}