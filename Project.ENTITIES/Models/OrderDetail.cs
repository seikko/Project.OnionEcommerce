using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
    public class OrderDetail:BaseEntity // junction tablo (n-n) ilişki.
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal TotalPrice { get; set; }
        public short Quantity { get; set; }
        //Relational Properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
