using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Orders.Commands.CreateOrder
{
    public interface ICreateOrderCommand
    {
        void Execute(CreateOrderModel model);
    }
}
