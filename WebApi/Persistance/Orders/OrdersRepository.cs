using Application.Interfaces.Persistence;
using Domain.Orders;
using Persistance.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Orders
{
    public class OrdersRepository
        : Repository<Order>,
        IOrdersRepository
    {
        public OrdersRepository(IDatabaseContext database)
            : base(database) { }
    }
}
