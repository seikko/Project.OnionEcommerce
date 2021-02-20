using FluentValidation;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules
{
   public class CategoryValidator:BaseValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty();
            RuleFor(x => x.Description).MinimumLength(2);
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
