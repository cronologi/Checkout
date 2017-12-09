using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Orders
{
    public class OrderDetail : IEntity
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public Guid Id { get; set; }
    }
}
