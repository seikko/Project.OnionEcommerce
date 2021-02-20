using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
  public  class Order:BaseEntity
    {
      
        public string ShippedAddress { get; set; }
        public decimal TotalPrice { get; set; }
        //Sipariş işlemlerinin icerisindeki bilgileri daha rahat yakalamak adına actıgımız property'lerdir
        public string UserName { get; set; }
        public string Email { get; set; }
        public string EmailAddress { get; set; }

        //Relational Properties
        public virtual List<OrderDetail> OrderDetails { get; set; }
      

    }
}
