using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   List_practice.Models.Services
{
    internal interface IProduct
    {
        List<Product> GetAll();
        Product GetById(int id);

        List<Product> GetAllByDecending();
    }
}
