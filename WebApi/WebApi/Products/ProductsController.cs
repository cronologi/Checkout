using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Products.Queries.GetProducts;

namespace WebApi.Products
{
    [Produces("application/json")]
    [Route("api/v1/products")]
    public class ProductsController : Controller
    {
        private readonly IGetProductsQuery _query;

        public ProductsController(IGetProductsQuery query)
        {
            _query = query;
        }

        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            return _query.Execute();
        }
    }
}