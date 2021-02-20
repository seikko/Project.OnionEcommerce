using Project.DAL.DALModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Abstract
{
    public interface IUserManagerSpecial
    {
        //Identity aslında bir API'dır...  

        //Identity kullanıyorsanız sizi Async metotlarla calısma durumunda bırakır
        Task<bool> AddUser(AppUser item);
    }

    //Normal bir metodumuz asenkron calısmak istiyorsa basına Task almak zorundadır...

    //Eger kendimize has bir User'imiz yok ise IdentityUser üzerinden bu işlemleri yaparız...
}
