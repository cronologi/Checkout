using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.Queries.GetProducts
{
    public class ProductModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
