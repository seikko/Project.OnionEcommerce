using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstract;
using Project.CoreUI.VMClasses;
using Project.DAL.DALModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.CoreUI.Controllers
{
    public class AccountController : Controller
    {

        IUserManagerSpecial _ums;
        ILoginManager _ilm;
        public AccountController(IUserManagerSpecial usm, ILoginManager ilm)
        {
            _ums = usm;
            _ilm = ilm;
        }
        public IActionResult RegisterSuccess()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AppUserVM avm)
        {
            AppUser newUser = new AppUser
            {
                UserName = avm.UserName,
                Email = avm.Email,
                PasswordHash = avm.Password
            };
            if (await _ums.AddUser(newUser)) return RedirectToAction("RegisterSuccess");
            return View(avm);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM lvm)
        {
            bool result = await _ilm.SignInUser(new AppUser
            {
                UserName = lvm.UserName,
                PasswordHash = lvm.Password
            },
            lvm.RememberMe);

            if (result) return RedirectToAction("CategoryList", "Category");
            return View();
            
        }
    }
}
