using Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Shared
{
    public class DatabaseInitializer
    {
        public static int Initialize(IDatabaseContext context)
        {
            context.EnsureDatabaseCreated();

            context.Products.AddRange(new Product[] 
            {
                new Product()
                {
                    Id = Guid.Parse("700ee90f-e3a4-42f8-80ac-fcaee7cb253c"),
                    Name = "Bag",
                    Price = 20.00M
                },
                new Product()
                {
                    Id = Guid.Parse("6788d223-8c59-4cb7-b344-796b05a4f070"),
                    Name = "Pen",
                    Price = 5.00M
                },
                new Product()
                {
                    Id = Guid.Parse("b67818b6-40fe-47e2-88db-b25081ba7749"),
                    Name = "Book",
                    Price = 35.00M
                }
            });

            return context.Save().Result;
        }
    }
}
