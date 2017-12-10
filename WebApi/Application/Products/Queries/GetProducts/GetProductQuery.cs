using Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Products.Queries.GetProducts
{
    public class GetProductsQuery : IGetProductsQuery
    {
        private readonly IProductRepository _repository;

        public GetProductsQuery(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<ProductModel> Execute()
        {
            var products = _repository.GetAll()
                .Select(p => new ProductModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                });

            return products.ToList();
        }
    }
}
