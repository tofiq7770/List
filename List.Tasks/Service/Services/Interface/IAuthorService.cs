using List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Services.Interface
{
    public interface IAuthorService
    {
        public List<Author> GetAll();

        public List<Author> GetByAge(int age);
    }
}
