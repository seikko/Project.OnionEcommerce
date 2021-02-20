using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
   public class Product :BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public short UnitInStock { get; set; }
        public string ImagePath { get; set; }

        public int? CategoryID { get; set; } //Urunun kategorısıde olmayabilir oldugundan nullable veriyorum.

        //Relational Properties
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
