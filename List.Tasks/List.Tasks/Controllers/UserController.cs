using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List.Models;
using List.Services.Data;
using List.Services.Interface;
using List.Services;

namespace List.Controllers
{
    internal class UserController
    {
        private readonly ProductService _productService;

        public UserController()
        {

            _productService = new ProductService();
        }
        private static void DisplayProducts(List<Product> products)
        {
            Console.WriteLine("Mehsullar:");
            foreach (var product in products)  
            {
                Console.WriteLine($"ID: {product.Id}, Ad: {product.Name}, Qiymet: {product.Price}");
            }
            Console.WriteLine();
        }
        public void DisplayMenu()
        {
            Console.WriteLine("1. Butun mehsulları goster");
            Console.WriteLine("2. Mehsulları axtar");
            Console.WriteLine("3. Bitir");
        }

        public void Display()
        {
            while (true)
            {
                DisplayMenu();
                Console.Write("Sechiminizi daxil edin (1, 2 ve ya 3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        List<Product> allProducts = _productService.GetAll();
                        DisplayProducts(allProducts);
                        break;

                    case "2":

                        Console.Write("Axtarmaq istediyiniz mehsulun adini daxil edin: ");
                        string searchText = Console.ReadLine();
                        List<Product> searchResult = _productService.SearchProducts(searchText);
                        DisplayProducts(searchResult);
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Yanlish secim. Zehmet olmasa, dogru secimi daxil edin.");
                        break;
                }
            }

        }
    }
}