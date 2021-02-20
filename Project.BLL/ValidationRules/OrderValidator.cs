using FluentValidation;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules
{
  public  class OrderValidator:BaseValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.ShippedAddress).NotEmpty();
            RuleFor(x => x.ShippedAddress).MinimumLength(10);
        }
    }
}
