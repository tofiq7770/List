using List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Services.Interface
{
    internal interface IProductService
    {
        public List<Product> GetAll();

    }
}
