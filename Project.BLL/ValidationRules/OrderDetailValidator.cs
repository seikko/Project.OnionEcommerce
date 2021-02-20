using FluentValidation;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules
{
   public class OrderDetailValidator:BaseValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.Quantity).NotEmpty();
        }
    }
}
