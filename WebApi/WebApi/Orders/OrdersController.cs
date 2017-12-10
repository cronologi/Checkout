using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Products.Queries.GetProducts;
using Application.Interfaces.Persistence;
using System.Net;

namespace WebApi.Products
{
    [Route("api/v1/orders")]
    public class OrdersController : Controller
    {
        private readonly IOrderRepository _repository;

        public OrdersController(IOrderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var order = await _repository.GetAsync(id);

            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {

            return Ok();
        }

        [Route("checkout")]
        [HttpPost]
        public async Task<IActionResult> Checkout()
        {
           
            return Accepted();
        }

        // DELETE api/values/5
        [HttpDelete("clear/{id}")]
        public void Delete(string id)
        {
        }

    }
}
