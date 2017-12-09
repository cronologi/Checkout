using Domain.Common;
using Domain.Orders;
using Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Shared
{
    public interface IDatabaseContext
    {
        DbSet<Product> Products { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<OrderDetail> OrderDetail { get; set; }

        DbSet<T> Set<T>() where T : class, IEntity;

        Task EnsureDatabaseCreated();

        Task<int> Save();
    }
}
