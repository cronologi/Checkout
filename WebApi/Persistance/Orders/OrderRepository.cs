using Application.Interfaces.Persistence;
using Domain.Orders;
using Persistance.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Orders
{
    public class OrderRepository
        : Repository<Order>,
        IOrderRepository
    {
        public OrderRepository(IDatabaseContext database)
            : base(database) { }
    }
}
