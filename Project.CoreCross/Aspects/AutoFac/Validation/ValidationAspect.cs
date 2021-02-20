using Castle.DynamicProxy;
using FluentValidation;
using Project.CoreCross.CrossCuttingConcens.Validator;
using Project.CoreCross.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.CoreCross.Aspects.AutoFac.Validation
{
   public  class ValidationAspect:MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception("Bu bir hata fırlatma mesajıdır.");
            }
            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);//reflection çalısma esnasında birşeyleri calıstırmanı saglar ornek olarak birleyi newlemek ıstıyoruz onları calısma anında yapmak ıstersek vs gıbı gıbı gıbı
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//ornek productValidator'un calısma tıpını bul diyoruz. 
            var entities = invocation.Arguments.Where(x => x.GetType() == entityType); //ilgili metodun paremetrelerini bul demek(validator)ün tipine eşit olan parametreleri bul diyebiliriz yada


            foreach (var item in entities)
            {
                //validationTool u kullanarak validate et 
                ValidationTool.Validate(validator, item);
            }
        }
    }
}
