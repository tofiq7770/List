using List_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_practice.Data
{
    internal static class AppDbContext
    {
        public  static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name="iphone",
                    Price=3000


                },
                new Product
                {
                    Id = 2,
                    Name="Nokia",
                    Price=300


                },
                new Product
                {
                    Id = 3,
                    Name="Samsung",
                    Price=2000


                }
            };
        }
    }
}
