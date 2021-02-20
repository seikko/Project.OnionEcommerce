using Project.ENTITIES.CoreInterfaces;
using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
    //BaseEntity'nin abstarct olmasının sebebi sadece miras vericek olan class olmasıdır. IEntity'den miras Alıp Diger class lara sadece miras verecektir. Instance'ı alınmicaktır.
    public abstract class BaseEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime? ModifiedDate { get; set ; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? CreatedDate { get ; set ; }
        public DataStatus? Status { get ; set; }
       

        public BaseEntity()
        {
            Status = DataStatus.Inserted; //girilen verinin durumu inserted olacak
            CreatedDate = DateTime.Now;
        }
    }
}
