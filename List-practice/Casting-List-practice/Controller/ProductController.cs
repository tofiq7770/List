using List_practice.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  List_practice.Controller
{
    internal class ProductController
    {
        private readonly IProduct _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }

        public void GetAll()
        {
            var datas=_productService.GetAll();
            foreach (var item in datas)
            {
                Console.WriteLine(item.Name+" "+item.Price);
            }
        }

        public void GetById()
        {
           
            var datas = _productService.GetById(2);
              Console.WriteLine(datas.Name + " " + datas.Price);
           
        }

        public void Sorting()
        {
            var datas = _productService.GetAllByDecending();
            foreach (var item in datas)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
        }
    }
}
