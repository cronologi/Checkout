using Application.Interfaces.Persistence;
using Domain.Products;
using Persistance.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(IDatabaseContext database)
            : base(database) { }
    }
}
