using Project.BLL.Constans.ValidationMessanges;
using Project.BLL.ManagerServices.Abstract;
using Project.BLL.ValidationRules;
using Project.CoreCross.Aspects.AutoFac.Validation;
using Project.CoreCross.Utilities.Results;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ManagerServices.Concrets
{
    [ValidationAspect(typeof(ProductValidator))]
    public class ProductManager:BaseManager<Product>,IProductManager
    {
        public ProductManager(IRepository<Product> prd):base(prd)
        {

        }

       //AOP ornegidir.
        public override IResult Add(Product item)//bu şekilde bas'deki gorevleri ezip farklı gorevler tanımlayabilirim artık.
        {
            _irp.Add(item);
            return new SuccessDataResult<Product>(Messanges.Added);
        }
        public override IResult Update(Product item)
        {
            return base.Update(item);
        }

    }
}
