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
    public class AuthorService : IAuthorService
    {
        List<Author> IAuthorService.GetAll()
        {
            return AppDbContext.Authors();
        }

        List<Author> IAuthorService.GetByAge(int age)
        {
            return AppDbContext.Authors();
        }
    }
}
