using FluentValidation;
using Project.ENTITIES.CoreInterfaces;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules
{
  public  class BaseValidator<T> : AbstractValidator<T> where T :BaseEntity,IEntity
    {

        public BaseValidator()
        {
            //RuleFor(x => x.CreatedDate).NotEmpty(); // bu sadece 1 ornektir istersek base sınıftan butun miras verdigimiz sınıflara 1 sart kosabılırız.
        }
    }
}
