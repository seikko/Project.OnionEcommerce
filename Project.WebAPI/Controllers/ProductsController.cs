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
    public class ProductsController : ControllerBase
    {
        private IProductManager _productManager;
        public ProductsController(IProductManager productmanager)
        {
            _productManager = productmanager;
        }

        [HttpGet("getAllProduct")]
        public IActionResult GetAll()
        {
            var result = _productManager.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }
        [HttpPost("addProduct")]
        public IActionResult AddProduct(Product item)
        {
            var result = _productManager.Add(item);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }
        [HttpPost("deleteProduct")]
        public IActionResult DeleteProduct(Product item)
        {
            var result = _productManager.Delete(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result);
        }
        [HttpPost("updateProduct")]
        public IActionResult UpdateProduct(Product item)
        {
            var result = _productManager.Update(item);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }


    }
}
