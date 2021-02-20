using Microsoft.AspNetCore.Identity;
using Project.ENTITIES.CoreInterfaces;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.DALModel
{
    public class AppUser : IdentityUser,IEntity
    {

        //AppUser IdentityUser'dan miras alarak bu sınıfın ozellıklerını içine almak istiyorsa artık nerede IdentityUser kullanıcak isek oraya AppUser class'ını yazmalıyız.
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Password { get; set; }
        public DateTime? ModifiedDate { get; set ; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DataStatus? Status { get; set ; }
        
    }
}
