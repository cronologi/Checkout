using Domain.Common;
using Domain.Orders;
using Domain.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Shared
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        public void EnsureDatabaseCreated()
        {
            Database.EnsureCreated();
        }

        public async Task<int> Save()
        {
            return await this.SaveChangesAsync();
        }

        public new DbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("CheckoutDB");
        }
    }
}
