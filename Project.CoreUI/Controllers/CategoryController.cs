using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstract;
using Project.CoreUI.VMClasses.PAVM;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.CoreUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryManager _icm;
        public CategoryController(ICategoryManager icm)
        {
            _icm = icm;
        }
        //public IActionResult CategoryList()
        //{
        //    CategoryPageVM pavm = new CategoryPageVM
        //    {
        //        Categories = _icm.GetAll()
        //    };
        //    return View(pavm);
        //}

        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category item)
        {
            TempData["mesaj"] = _icm.Add(item);
            return RedirectToAction("AddCategory");
           
        }
    }
}
