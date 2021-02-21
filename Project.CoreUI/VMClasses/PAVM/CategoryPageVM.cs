using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.CoreUI.VMClasses.PAVM
{
    public class CategoryPageVM
    {
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}
