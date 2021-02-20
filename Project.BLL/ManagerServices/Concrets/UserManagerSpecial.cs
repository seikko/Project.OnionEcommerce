using Microsoft.AspNetCore.Identity;
using Project.BLL.ManagerServices.Abstract;
using Project.DAL.DALModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concrets
{
    public class UserManagerSpecial : IUserManagerSpecial
    {
        UserManager<AppUser> _umanager;
        SignInManager<AppUser> _smanager;

        public UserManagerSpecial(UserManager<AppUser> umanager, SignInManager<AppUser> smanager)
        {
            _umanager = umanager;
            _smanager = smanager;
        }
        public async Task<bool> AddUser(AppUser item)
        {
            IdentityResult result = await _umanager.CreateAsync(item, item.PasswordHash);
            if(result.Succeeded)
            {
                await _smanager.SignInAsync(item, isPersistent: false);
                return true;
            }
            return false;
        }
    }
}
