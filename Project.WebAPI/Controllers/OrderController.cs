using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstract;
using Project.BLL.ManagerServices.Concrets;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private IOrderManager _orderManager;
        public OrderController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        [HttpGet("orderGetAll")]
        public IActionResult GetAll()
        {
            var result = _orderManager.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }
        [HttpPost("addOrder")]
        public IActionResult AddOrder(Order item)
        {
            var result = _orderManager.Add(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
        [HttpPost("deleteOrder")]
        public IActionResult DeleteOrder(Order item)
        {//veri durumunu degistirir
            var result = _orderManager.Delete(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
        [HttpPost("destroyOrder")]
        public IActionResult DestroyOrder(Order item)
        {//veriyi yok eder.
            var result = _orderManager.Destroy(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
        [HttpPost("updateOrder")]
        public IActionResult UpdateOrder(Order item)
        {
            var result = _orderManager.Update(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }

    }
}
