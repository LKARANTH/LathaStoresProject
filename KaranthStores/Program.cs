using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranthStores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome to Karanth Stores!********");
            Console.WriteLine("Please select from the following option");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Please place an order");
            Console.WriteLine("2: sold");
            Console.WriteLine("3: received");
            Console.WriteLine("4: Print all Products");
            var option = Console.ReadLine();
            var product = new Product();
            switch (option)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting! Good bye!");
                    break;
                case "1":
                    Console.WriteLine(" Enter Manufacturer Name");
                    var Manufacturer = Console.ReadLine();
                    product.Manufacturer = Manufacturer;
                    Console.WriteLine(" Enter Product Name");
                    var ProductName = Console.ReadLine();
                    product.ProductName = ProductName;
                    Console.WriteLine(" Enter Type Of Product");
                    var TypeOfProduct = Console.ReadLine();
                    product.TypeOfProduct = TypeOfProduct;
                    Console.WriteLine(" Enter the Quantity");
                    int Quantity = Convert.ToInt32 (Console.ReadLine());
                    product.Quantity = Quantity;
                    Console.WriteLine($"Manufacturer: {product.Manufacturer}, ProductName: {product.ProductName}, TypeOfProduct: {product.TypeOfProduct}, Quantity: {product.Quantity}");
                break;
                case "2":
                case "3":
                case "4":
                    var products = Stores.GetAllProducts();
                    foreach (var product in products) 
                    {
                        Console.WriteLine($"Manufacturer: {product.Manufacturer}, ProductName: {product.ProductName}, TypeOfProduct: {product.TypeOfProduct}, Quantity: {product.Quantity}");
                    }
                    break;
                default:
                    break;
            }
       }
    }
}
