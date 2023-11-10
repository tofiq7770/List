using List.Models;
using List.Services.Data;
using List.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();
        }
        public List<Product> SearchProducts(string searchText)
        {
            searchText = searchText.ToLower();
            return GetAll().FindAll(product => product.Name.ToLower().Contains(searchText));
        }
    }
}
