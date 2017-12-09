using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Products
{
    public class Product : IEntity
    {
        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public Guid Id { get; set; }
    }
}
