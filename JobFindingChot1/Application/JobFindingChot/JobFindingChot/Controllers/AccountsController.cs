using JobFindingChot.Enums;
using JobFindingChot.Extension;
using JobFindingChot.Helpers;
using JobFindingChot.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JobFindingChot.Controllers
{
    public class AccountsController : Controller
    {
        private JobFindingChot1Context _context = new JobFindingChot1Context();

        public object Session { get; private set; }

        public IActionResult NewUser()
        {
            return View(new AccountMV());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewUser(AccountMV accountMV)
        {
            if (ModelState.IsValid)
            {
                var checkuser = _context.Accounts.Where(u => u.Email == accountMV.Email).FirstOrDefault();
                if (checkuser != null)
                {
                    ModelState.AddModelError("Email", "Email is already Registered!");
                    return View(accountMV);
                }
                checkuser = _context.Accounts.Where(u => u.FullName == accountMV.FullName).FirstOrDefault();
                if (checkuser != null)
                {
                    ModelState.AddModelError("FullName", "UserName is already Registered!");
                    return View(accountMV);
                }
                //using (var trans = _context.Database.BeginTransaction()) {
                // try

                var user1 = new Account();
                user1.FullName = accountMV.FullName;
                user1.Password = accountMV.Password;
                user1.Phone = accountMV.Phone;
                user1.Email = accountMV.Email;
                user1.RoleId = accountMV.AreYouProvider == true ? 2 : 3;
                user1.CreatedDate = accountMV.CreatedDate;
                user1.LastLogin = accountMV.LastLogin;
                _context.Accounts.Add(user1);
                _context.SaveChanges();

                //Nếu đăng ký là Provider
                /*if (accountMV.AreYouProvider == true)
                {
                    var company = new Company();
                    company.AccountId = user1.AccountId;
                    if(string.IsNullOrEmpty(accountMV.Company.Email))
                    {
                        trans.Rollback();
                        ModelState.AddModelError("Company.Email", "Required*");
                        return View(accountMV);
                    }
                    if (string.IsNullOrEmpty(accountMV.Company.CompanyName))
                    {
                        trans.Rollback();
                        ModelState.AddModelError("Company.CompanyName", "Required*");
                        return View(accountMV);
                    }
                    if (string.IsNullOrEmpty(accountMV.Company.Phone))
                    {
                        trans.Rollback();
                        ModelState.AddModelError("Company.Phone", "Required*");
                        return View(accountMV);
                    }
                    if (string.IsNullOrEmpty(accountMV.Company.Description))
                    {
                        trans.Rollback();
                        ModelState.AddModelError("Company.Description", "Required*");
                        return View(accountMV);
                    }

                    company.Email = accountMV.Company.Email;
                    company.CompanyName = accountMV.Company.CompanyName;
                    company.Phone = accountMV.Phone;
                    company.Logo = "~/assets/img/logo/logo.png";
                    company.Description = accountMV.Company.Description;
                    _context.Companies.Add(company);
                    _context.SaveChanges();
                }
                trans.Commit();
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Please provide correct detail!");
                trans.Rollback();
            }

    }*/
            }
            return View(accountMV);
        }
        //trans.Commit();
        public ActionResult Login()
        {
            return View(new AccountLoginMV());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AccountLoginMV accountLoginMV)
        {

            if (ModelState.IsValid)
            {

                var user1 = _context.Accounts.Where(u => u.Email == accountLoginMV.Email && u.Password == accountLoginMV.Password).FirstOrDefault();
                if (user1 == null)
                {
                    ModelState.AddModelError(string.Empty, "Email or Password is incorrect! ");
                    return View(accountLoginMV);
                }
                var AccountId = user1.AccountId;
                var Email = user1.Email;
                var RoleId = user1.RoleId;
                if (user1.RoleId == 2)
                {
                    var CompanyId = user1.Companies.FirstOrDefault().CompanyId;
                }
                return RedirectToAction("Index", "Home");
            }
            return View(accountLoginMV);
        }
        public IActionResult Logout()
        {
            var AccountId = string.Empty;
            var Email = string.Empty;
            var CompanyId = string.Empty;
            var RoleId = string.Empty;
            return RedirectToAction("Index", "Home");
        }
    }
}
