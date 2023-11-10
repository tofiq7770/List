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
    internal class AccountService : IUserService
    {
        public string Login(string username, string password)
        {
            return AppDbContext.Users().Where(x => x.Password == password).ToString();
        }
    }
}
