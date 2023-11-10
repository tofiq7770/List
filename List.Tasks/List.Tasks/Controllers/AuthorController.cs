using List.Services;
using List.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Controllers
{
    internal class AuthorController
    {
        private readonly IAuthorService _authorService;
        public AuthorController()
        {
            _authorService = new AuthorService();
        }

        public void GetByAge()
        {
            var data = _authorService.GetAll();
            foreach (var item in data)
            {
                if (item.Age > 40) 
                {
                    Console.WriteLine(item.Name + " " + item.Surname);
                }
            }
        }
    }
}
