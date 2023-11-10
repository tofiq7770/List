using List_practice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  List_practice.Models.Services
{
    public class ProductService : IProduct
    {
        List<Product> IProduct.GetAll()
        {
            return AppDbContext.Products();
        }

        List<Product> IProduct.GetAllByDecending()
        {
            return AppDbContext.Products().OrderByDescending(x=>x.Price).ToList();
        }

        Product IProduct.GetById(int id)
        {
            return AppDbContext.Products().FirstOrDefault(x => x.Id == id);
        }
    }
}
