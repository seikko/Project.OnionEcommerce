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
            /*Buraya istersek base'deki gorevlerden farklı if yapabiliriz durumu ona gore de kontrol edebılırız.*/
            _irp.Add(item);
            return new SuccessDataResult<Product>(Messanges.Added);
        }
        public override IResult Update(Product item)
        {

            _irp.Update(item);
            return new SuccessDataResult<Product>(Messanges.Updated);
        }
        public override IResult Delete(Product item)
        {
            //veri durumunu deleted a cektik
            _irp.Delete(item);
            return new SuccessDataResult<Product>(Messanges.Deleted);
        }
        public override IResult Destroy(Product item)
        {

            _irp.Destroy(item); //veriyi yok ettık 
            return new SuccessDataResult<Product>(Messanges.Deleted);
        }

    }
}
