using FluentValidation;
using Project.DAL.DALModel;
using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules
{
   public class AppUserValidator:AbstractValidator<AppUser>
    {
        public AppUserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.PasswordHash).NotEmpty();
            RuleFor(x => x.PasswordHash).MinimumLength(6);
            RuleFor(x => x.PasswordHash).MaximumLength(8);
            RuleFor(x => x.Email).NotEmpty().WithMessage("Buraya istersek fırlatabilecegimiz hatayı yazabiliriz.");
        }
    }
}
