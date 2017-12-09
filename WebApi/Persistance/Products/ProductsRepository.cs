using Application.Interfaces.Persistence;
using Domain.Products;
using Persistance.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Products
{
    public class ProductsRepository : Repository<Product>, IProductsRepository
    {
        public ProductsRepository(IDatabaseContext database)
            : base(database) { }
    }
}
