using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;

        }

        [HttpGet("getAllCategory")]
        public IActionResult GetAll()
        {
            var result = _categoryManager.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("addCategory")]
        public IActionResult AddCategory(Category item)
        {
            var result = _categoryManager.Add(item);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }

         [HttpPost("deleteCategory")]
         public IActionResult DeleteCategory (Category item)
        {//DeleteCategory sadece veri durumunu Deleted'a cekecektir.
            var result = _categoryManager.Delete(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
        [HttpPost("destroyCategory")]
        public IActionResult DestroyCategory(Category item)
        {//Destroy dedigimizde veriyi yok etmek diyoruz
            var result = _categoryManager.Destroy(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
        [HttpPost("updateCategory")]
        public IActionResult UpdateCategory(Category item)
        {
            var result = _categoryManager.Update(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
    }
}
