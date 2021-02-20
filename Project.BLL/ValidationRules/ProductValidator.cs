using FluentValidation;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules
{
    public class ProductValidator:BaseValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty();//BrandName boş geçilmesin
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Buraya fırlatılacak hata mesajı yazılır bu şekilde kullanımları da mevcut dur.");//minumun karakteri 3 olsun

            RuleFor(x => x.UnitPrice).NotEmpty();
            RuleFor(x => x.UnitInStock).NotEmpty();
        }
    }
}
