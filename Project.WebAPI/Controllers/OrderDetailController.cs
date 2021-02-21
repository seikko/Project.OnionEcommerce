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
    public class OrderDetailController : ControllerBase
    {
        private IOrderDetailManager _orderDetailManager;
        public OrderDetailController(IOrderDetailManager orderDetailManager)
        {
            _orderDetailManager = orderDetailManager;
        }
        [HttpGet("orderDetailGetAll")]
        public IActionResult GetAll()
        {
            var result = _orderDetailManager.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }
        [HttpPost("addOrderDetail")]
        public IActionResult AddOrder(OrderDetail item)
        {
            var result = _orderDetailManager.Add(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
        [HttpPost("deleteOrderDetail")]
        public IActionResult DeleteOrder(OrderDetail item)
        {//veri durumunu degistirir
            var result = _orderDetailManager.Delete(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
        [HttpPost("destroyOrderDetail")]
        public IActionResult DestroyOrder(OrderDetail item)
        {//veriyi yok eder.
            var result = _orderDetailManager.Destroy(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
        [HttpPost("updateOrderDetail")]
        public IActionResult UpdateOrder(OrderDetail item)
        {
            var result = _orderDetailManager.Update(item);
            if (result.Success) return Ok(result.Success);
            return BadRequest(result.Message);
        }
    }
}
