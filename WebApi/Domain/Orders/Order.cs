using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Orders
{
    public class Order : IEntity
    {
        public decimal Total { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public Guid Id { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}
