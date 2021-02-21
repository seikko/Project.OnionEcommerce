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
   public class CategoryManager:BaseManager<Category>,ICategoryManager
    {
        public CategoryManager(IRepository<Category> cty):base(cty)
        {

        }
        [ValidationAspect(typeof(CategoryValidator))]
        public override IResult Add(Category item)
        {

            _irp.Add(item);
            return new SuccessDataResult<Category>(Messanges.Added);
        }
        public override IResult Destroy(Category item)
        {

            _irp.Delete(item);
            return new SuccessDataResult<Category>(Messanges.Deleted);
        }
        public override IResult Update(Category item)
        {

            _irp.Update(item);
            return new SuccessDataResult<Category>(Messanges.Updated);
        }

    }
}
