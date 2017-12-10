using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Orders.Commands.CreateOrder
{
    public class CreateOrderModel
    {
        public List<OrderItemModel> OrderItems { get; set; }
    }
}
