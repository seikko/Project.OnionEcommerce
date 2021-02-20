using Microsoft.AspNetCore.Identity;
using Project.BLL.ManagerServices.Abstract;
using Project.DAL.DALModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concrets
{
   public  class LoginManager :ILoginManager
    {
        SignInManager<AppUser> _smanager;

        public LoginManager(SignInManager<AppUser> smanager)
        {
            _smanager = smanager;
        }

        public async Task<bool> SignInUser(AppUser item, bool remember)
        {
            SignInResult result = await _smanager.PasswordSignInAsync(item.UserName, item.PasswordHash, remember, false);
            if (result.Succeeded) return true;
            return false;
        }
    }
}
