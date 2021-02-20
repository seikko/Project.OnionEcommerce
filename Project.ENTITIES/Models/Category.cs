using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Product> Products { get; set; } // virtual ile işaretlememizin sebebi lazyLoading tetiklenebilmesi için
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
