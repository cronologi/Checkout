using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Products.Queries.GetProducts
{
    public interface IGetProductsQuery
    {
        List<ProductModel> Execute();
    }
}
