using Project.DAL.DALModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Abstract
{
   public  interface ILoginManager
    {
        Task<bool> SignInUser(AppUser item, bool remember);
    }
}
