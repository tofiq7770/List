using List.Models;
using List.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List.Services.Data
{
    public static class AppDbContext
    {
        #region Authors
        public static List<Author> Authors()
        {
            return new List<Author>()
            {

                new Author()
                {
                    Id = 1,
                    Name="author1",
                    Surname="author1",
                    Age=19,
                },
                 new Author()
                {
                    Id = 2,
                    Name="author2",
                    Surname="author2",
                    Age=47
                },
                  new Author()
                {
                    Id = 3,
                    Name="author3",
                    Surname="author3",
                    Age=54,
                },
                   new Author()
                {
                    Id = 4,
                    Name="author4",
                    Surname="author4",
                    Age=72
                }
            };

        }
        #endregion

        #region Employees
        public static List<Employee> Employees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    Name="Tofiq",
                    Surname="Nasibli",
                    Salary=3500,
                    Birthday=new DateTime(2004,10,17)
                },

                new Employee()
                {
                    Id=2,
                    Name="Haci",
                    Surname="Ahmedov",
                    Salary=2500,
                    Birthday=new DateTime(1995,01,05)


                },
                  new Employee()
                {
                    Id=3,
                    Name="Meryem",
                    Surname="Aliyeva",
                    Salary=1500,
                    Birthday=new DateTime(2000,02,07)

                }
            };
        }
        #endregion

        #region Users

        public static List<User> Users()
        {
            return new List<User>()
            {
                new User()
                {
                    Id=1,
                    Username="Ali",
                    Password="ali123"

                },
                 new User()
                {
                    Id=2,
                    Username="Veli",
                    Password="123432"

                },
                  new User()
                {
                    Id=3,
                    Username="taril",
                    Password="7707"

                },
            };
        }
        #endregion

        #region Products

        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id= 1,
                    Name="Iphone",
                    Price=3500
                },
                  new Product()
                {
                    Id= 2,
                    Name="Samsung",
                    Price=3000
                },
                    new Product()
                {
                    Id= 3,
                    Name="Nokia",
                    Price=20
                }
            };
        }

        #endregion

    }
}
